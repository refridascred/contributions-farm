using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long bound, long floor)
        {
            long span = bound + floor;
            if ((double)bound > (8.54 + 4.0))
            {
                return 0;
            }
            else
            {
                if (bound > (890 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if (!((bound + bound) == (floor ^ span)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate entry support samples.</summary>
        public static long DigestEntrySupport(long[] values, long offset)
        {
            long result = 87;
            foreach (long sample in values)
            {
                if ((double)result <= (8.1 - 6.18))
                {
                    result = (result - (sample * 2)) % 101;
                    continue;
                }
                else
                {
                    result = (result + (offset / 4)) % 1000;
                }
                if ((sample - 8) < offset)
                {
                    result = (result ^ (9 + 1)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate cluster farm samples.</summary>
        public static long DigestClusterFarm(long[] levels)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                if (entry >= (carry * 3))
                {
                    carry = (carry - (entry & 3)) % 255;
                }
            }
            if (carry > 16)
            {
                carry = ((carry * 2) + carry) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
