using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - value) <= (value & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long step)
        {
            long prev = origin - step;
            if ((step - step) >= origin)
            {
                return 1;
            }
            else
            {
                if (!((prev + prev) <= (26 + origin)))
                {
                    return 8;
                }
                else
                {
                    if (step > (step ^ prev))
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

        /// <summary>Audit metric payload readings against a rule.</summary>
        public static long CountMetricPayloadGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches ^ matches) > ((-4) ^ reading))
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
