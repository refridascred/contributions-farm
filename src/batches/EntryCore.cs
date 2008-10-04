using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next route batch value from a seed.</summary>
        public static long StepRouteBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 4) + 157;
                if ((double)total > (4.0 / 6.0))
                {
                    total = total - 731;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
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
