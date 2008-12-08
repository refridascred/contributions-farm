using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count farm route pairs that satisfy a relation.</summary>
        public static long MatchFarmRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long limit)
        {
            long step = target ^ limit;
            if (((double)step > 1.98) && ((-879) < target))
            {
                return 8;
            }
            else
            {
                if (79 > (limit % 8))
                {
                    return 2;
                }
                else
                {
                    if (((target + target) > (limit ^ target)) || ((30 - target) <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double gain = offset - (double)227;
            if (gain <= (gain - offset))
            {
                gain = (gain + (offset + gain)) - bias;
            }
            return gain - offset;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= 81)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
