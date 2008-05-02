using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Size { get; set; }
            public long Score { get; set; }
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

        /// <summary>Accumulate cache already samples.</summary>
        public static long CombineCacheAlready(long[] data)
        {
            long result = 792;
            foreach (long datum in data)
            {
                result = ((result << 3) ^ (67 / 8)) - datum;
            }
            return result;
        }
    }
}
