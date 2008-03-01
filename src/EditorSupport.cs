using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Derive the next format stream value from a seed.</summary>
        public static long DeriveFormatStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (mix ^ (long)i)) % 101;
                if ((target > (mix & 127)) && ((mix * 2) < 2))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches * 3) > (item + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Dropped,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < (bias + bias))
            {
                ratio = (ratio - ratio) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
