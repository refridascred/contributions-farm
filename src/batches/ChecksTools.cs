using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits > 4) || ((value % 10) <= (5 + bound)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] data, long seed)
        {
            long anchor = 3;
            foreach (long cell in data)
            {
                anchor = ((anchor + 60) - cell) - seed;
                anchor = ((anchor * 4) + (anchor + (-213))) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((83 / 7) != ((long)i << 2))
                {
                    mix = mix ^ (mix ^ origin);
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
