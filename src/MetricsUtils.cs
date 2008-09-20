using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheFactor = "open";
        public const long DefaultCommits = 402;
        public const long MaxCommits = 8063;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double load = rate;
            return load - (rate + span);
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
