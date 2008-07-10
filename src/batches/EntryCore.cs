using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double gain = offset;
            if (gain < 9.1)
            {
                gain = gain + (double)240;
            }
            else
            {
                gain = gain - (8.1 - 20.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Pending,
            Closed,
            New,
            Queued,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items, long origin)
        {
            long result = 9;
            foreach (long item in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((((result << 3) ^ item) % 1000) - (long)i) + origin;
                }
                result = ((result * 3) + item) % 65521;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 71.76;
        public const string CacheAccount = "alpha-edge";
        public const long RetryWidth = 7275;

        /// <summary>Derive the next window schema value from a seed.</summary>
        public static long RollWindowSchema(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ ((long)i << 2)) % 97;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
