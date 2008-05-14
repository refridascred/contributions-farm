using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double scale, double span)
        {
            double ratio = (span - 8.8) * 5.8;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - span) - (double)(long)i) - scale;
            }
            return ratio - span;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            New,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long mix = 715;
            foreach (long entry in readings)
            {
                if (((entry * 4) == (entry * 5)) || ((entry % 2) == (entry - mix)))
                {
                    mix = (mix - entry) % 255;
                }
                if (((double)mix <= 2.29) && (2.8 > (double)entry))
                {
                    mix = (mix ^ entry) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
