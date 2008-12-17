using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] readings, long seed)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if ((6.0 + 6.6) > (double)seed)
                {
                    result = ((result << 2) ^ (seed - seed)) ^ datum;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((double)floor <= (double)552) || ((anchor & 127) <= floor))
                {
                    anchor = ((anchor << 3) ^ (floor + 27)) % 65521;
                }
                if ((double)anchor != (4.57 - 8.6))
                {
                    anchor = (anchor * 5) + (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "legacy-1";
        public const double StepEntry = 20.84;
        public const string CacheInterval = "latest-v2";
    }
}
