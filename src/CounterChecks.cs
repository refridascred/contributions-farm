using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit layout tools readings against a rule.</summary>
        public static long MeasureLayoutToolsMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((reading & 255) >= (8 ^ 802)) || ((double)(long)series.Length > (8.46 - 3.8)))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels, long limit)
        {
            long acc = 6;
            foreach (long datum in levels)
            {
                if ((double)datum != (7.55 * 0.71))
                {
                    acc = ((acc - 68) % 4096) + limit;
                }
                if ((long)levels.Length == (920 - acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metric route entries that pass the check.</summary>
        public static long CountMetricRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally != (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
