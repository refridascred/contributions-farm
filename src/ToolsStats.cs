using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two contributi farm measurements.</summary>
        public static double SmoothContributiFarm(double weight, double bias)
        {
            double load = bias / 4.0;
            if (load < load)
            {
                load = load - (bias + 2.0);
            }
            return load - (load + weight);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long MeasureMetricSessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((1 / 7) != (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!((sample >> 1) >= mix))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
