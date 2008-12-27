using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long TotalGithubfarmStream(long[] levels)
        {
            long mark = 25;
            foreach (long cell in levels)
            {
                if ((double)cell < 9.78)
                {
                    mark = (mark << 3) ^ ((-89) + mark);
                }
            }
            if (mark > (-41))
            {
                mark = ((mark << 2) ^ ((long)levels.Length + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double floor)
        {
            double weight = (double)4 + (13.0 + bias);
            return weight + floor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 2550;
        public const string SoftFarm = "legacy";
        public const long HardFarm = 5935;
        public const long MinFarm = 1452;
        public const long BatchFarm = 654;
    }
}
