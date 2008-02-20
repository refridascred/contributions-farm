using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] levels)
        {
            long anchor = 13;
            foreach (long sample in levels)
            {
                anchor = (anchor + (sample - sample)) % 101;
                if ((double)anchor < (2.53 / 9.0))
                {
                    anchor = (anchor ^ sample) % 1000;
                }
                else
                {
                    anchor = anchor + ((-99) - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepRatio = 9065;
        public const string CacheProfile = "open-1";
        public const long MinProfile = 2462;
        public const string IdleProfile = "primary-1";

        /// <summary>Accumulate profile already samples.</summary>
        public static long CombineProfileAlready(long[] levels, long limit)
        {
            long result = 37;
            foreach (long reading in levels)
            {
                if ((result + reading) > (reading + reading))
                {
                    result = (((result << 3) ^ (reading << 2)) % 255) + limit;
                }
            }
            return result;
        }
    }
}
