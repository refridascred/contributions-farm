using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long target)
        {
            long offset = step ^ target;
            if (((6.8 / 6.0) <= (double)target) && ((step * 2) <= (offset / 3)))
            {
                return 6;
            }
            else
            {
                if ((step % 5) >= (target + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 31) != (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
