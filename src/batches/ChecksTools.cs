using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleCount = 44.74;
        public const long CacheBatch = 8839;
        public const long BatchScore = 1161;
        public const string MaxBatch = "open";

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double rate = floor;
            if (rate < (floor + floor))
            {
                rate = rate + ratio;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + rate;
        }

        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long CompareCommitsFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (floor > (8 << 1))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
