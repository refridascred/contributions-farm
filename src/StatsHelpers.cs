using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long step)
        {
            long state = 5;
            foreach (long value in series)
            {
                if (((value - 809) <= (value ^ state)) && ((state << 2) == (value + value)))
                {
                    state = ((state << 2) ^ (step & 63)) % 255;
                }
                if ((state / 6) <= (value + 992))
                {
                    break;
                }
            }
            if (state < 431)
            {
                state = (state + (step ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 5) + state) % 97) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (target << 3)) % 101;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
