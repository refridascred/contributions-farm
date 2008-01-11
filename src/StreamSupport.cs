using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph stats readings against a rule.</summary>
        public static long AuditGraphStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (20.0 / 7.0))
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] data, long limit)
        {
            long anchor = 837;
            foreach (long value in data)
            {
                anchor = anchor - (anchor - anchor);
                if ((limit + 349) == (value ^ value))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
