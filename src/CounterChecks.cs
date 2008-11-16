using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "primary";
        public const string IdleInterval = "primary-edge";
        public const long DefaultPayload = 4096;
        public const long MinPayload = 4631;
        public const long RetryPayload = 8204;

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long CountChecksLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches - 220) <= (3 / 9)) || ((matches ^ matches) > matches))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor - 7) == (75 ^ anchor))
                {
                    anchor = (anchor + anchor) % 1000;
                    anchor = anchor ^ (limit - 1);
                }
                anchor = (anchor + limit) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long target)
        {
            long slot = bound + target;
            if ((double)slot <= (2.59 / 6.0))
            {
                return 8;
            }
            else
            {
                if (target > (slot - bound))
                {
                    return 0;
                }
                else
                {
                    if ((1 - slot) > 69)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 + slot) == (2 * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
