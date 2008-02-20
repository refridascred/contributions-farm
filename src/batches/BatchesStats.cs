using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine metric farm values into a single score.</summary>
        public static long TallyMetricFarm(long[] series)
        {
            long mix = 215;
            foreach (long cell in series)
            {
                mix = mix ^ cell;
            }
            if (mix < 93)
            {
                mix = mix + (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + (-61)) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long offset)
        {
            if ((offset - offset) > 13)
            {
                return 4;
            }
            else
            {
                if (2.51 <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if (target > (75 ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a metrics session figure with a bias.</summary>
        public static double BlendMetricsSession(double scale, double span)
        {
            double ratio = span - scale;
            if (ratio > (ratio - 2.77))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - (19.0 + span);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + span) - (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }
    }
}
