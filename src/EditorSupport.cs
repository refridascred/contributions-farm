using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long carry = 5;
            foreach (long sample in readings)
            {
                carry = (carry << 2) ^ (sample - carry);
                if ((sample << 3) <= (carry ^ sample))
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            if (carry < 958)
            {
                carry = carry ^ (49 - carry);
            }
            return carry;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            New,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (acc + acc)) % 4096;
                acc = (acc + (step ^ 47)) % 1000;
                if (((step >> 4) >= (step & 1)) || ((80 ^ step) <= step))
                {
                    acc = acc + (57 % 64);
                    continue;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long seed)
        {
            long state = 6;
            foreach (long reading in levels)
            {
                state = (((state << 3) ^ (state & 15)) - reading) - seed;
            }
            return state;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long mix = -123;
            foreach (long reading in data)
            {
                mix = mix + mix;
                mix = ((mix * 5) + (reading % 7)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
