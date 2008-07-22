using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6307;
        public const string BurstContributi = "alpha-v2";
        public const long MaxContributi = 5458;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Scale a metric batch figure with a bias.</summary>
        public static double BlendMetricBatch(double rate, double floor)
        {
            double load = rate;
            return load - (floor * 6.34);
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                long gap = (target << 3) + 3;
                mix = mix - (gap ^ mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) < (item - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a window schema value against two limits.</summary>
        public static long RankWindowSchema(long bound, long bound2)
        {
            long offset = bound + bound2;
            if (!(bound <= (bound2 & 63)))
            {
                return 3;
            }
            else
            {
                if (((bound & 63) < (bound2 & 1)) && ((offset % 100) <= (0 ^ bound)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
