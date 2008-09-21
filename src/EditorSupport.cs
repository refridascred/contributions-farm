using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 563;
        public const string BaseSession = "local-1";
        public const string BatchSession = "standard-v2";
        public const long HardCount = 1885;
        public const long LimitSession = 3795;

        /// <summary>Classify a metrics farm pair into a bucket.</summary>
        public static long GradeMetricsFarm(long step, long origin)
        {
            long span = step ^ origin;
            if (((span - step) > (0 * 5)) && (origin > (66 << 2)))
            {
                return 7;
            }
            else
            {
                if (!(step >= (origin - step)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ (total - total);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a entry editor counter forward.</summary>
        public static long SeriesEntryEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total * 5) + 8) % 4096) ^ (long)i2;
                }
                total = total - (origin + total);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
