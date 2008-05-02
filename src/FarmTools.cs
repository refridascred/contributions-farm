using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!(seed >= (result * 4)))
                {
                    result = result - (seed * 3);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length + 65) != (value % 10))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
