using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= 9.4)
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - mix) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first counter commits entry that matches the target.</summary>
        public static long SeekCounterCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (load + 13.0)) + (double)(long)i) - span;
            }
            return load - 6.1;
        }
    }
}
