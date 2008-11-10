using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] series)
        {
            long mark = 2;
            foreach (long datum in series)
            {
                if ((14.0 - 8.0) < (double)datum)
                {
                    mark = (mark * 4) + mark;
                }
                if (75 < datum)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stats tools readings against a rule.</summary>
        public static long TallyStatsToolsHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!(((reading + (-22)) > reading) || (seen >= (seen + 989))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
