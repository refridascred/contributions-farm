using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ 91) % 1000;
                if (step > (step & 63))
                {
                    carry = (carry * 4) + (7 >> 3);
                    carry = ((carry << 2) ^ (step & 7)) % 4096;
                }
                else
                {
                    carry = ((carry * 2) + (carry ^ 963)) % 65521;
                }
                if (9.0 >= (double)carry)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long seed)
        {
            if ((floor / 5) == (6 >> 4))
            {
                return 1;
            }
            else
            {
                if ((floor * 2) > (86 ^ seed))
                {
                    return 6;
                }
                else
                {
                    if (464 >= (seed - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data)
        {
            long score = 4;
            foreach (long cell in data)
            {
                score = ((score << 3) ^ (cell ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowTimeout = 71.19;
        public const string BatchInterval = "open-1";
        public const long BatchBatches = 849;
        public const double BaseBatches = 37.35;
        public const long DefaultBatches = 4317;
    }
}
