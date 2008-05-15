using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long origin, long offset)
        {
            if ((offset & 127) <= origin)
            {
                return 4;
            }
            else
            {
                if (!((offset ^ offset) >= (offset - offset)))
                {
                    return 3;
                }
                else
                {
                    if (origin < (offset & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
