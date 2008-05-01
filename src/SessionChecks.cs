using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] data)
        {
            long result = 7;
            foreach (long item in data)
            {
                if (!(item > result))
                {
                    result = result - (item >> 1);
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long AuditQueueBatchGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen ^ (-74)) <= seen) && ((seen + 8) == ((-13) * 3)))
                {
                    seen = ((seen + 3) + entry) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchInterval = 1460;
        public const long LimitInterval = 6604;
        public const string LimitChannel = "standard";
        public const double BaseChannel = 0.45;
        public const long BatchChannel = 410;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
