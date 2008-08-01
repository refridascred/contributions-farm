using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a session stream value against two limits.</summary>
        public static long ClassifySessionStream(long seed, long origin)
        {
            long delta = seed ^ origin;
            if (delta <= (486 * 5))
            {
                return 5;
            }
            else
            {
                if (seed <= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if ((delta + origin) < delta)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.75 * 8.11) <= (double)seed) && ((delta + delta) == (delta & 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((115 >> 3) <= (matches + matches)) || ((2.14 - 7.26) < (double)cell)) && ((long)readings.Length >= (matches - cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a schema metric reading by value.</summary>
        public static long FindSchemaMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((3 >= seen) || (datum >= (datum - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
