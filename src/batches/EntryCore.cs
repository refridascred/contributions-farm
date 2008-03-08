using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double bias2 = (rate / 5.0) * 15.0;
            return (bias2 - 9.82) + bias;
        }

        /// <summary>Measure how many farm githubfarm samples are out of range.</summary>
        public static long TallyFarmGithubfarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell & 3) == (cell << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a checks githubfarm sample.</summary>
        public static long FindChecksGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
