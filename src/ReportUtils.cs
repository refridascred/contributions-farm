using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long seed)
        {
            long total = 6;
            foreach (long sample in samples)
            {
                if (seed < (sample * 3))
                {
                    total = (total ^ seed) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of farm account readings.</summary>
        public static long WeighFarmAccount(long[] values, long target)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                anchor = ((anchor + (cell >> 4)) % 101) - target;
            }
            if (anchor > (-3))
            {
                anchor = (anchor << 3) ^ (anchor ^ anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((4.2 * 3.0) == (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((matches + 876) > 643))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
