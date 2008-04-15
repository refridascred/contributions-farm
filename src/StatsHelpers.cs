using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long step, long limit)
        {
            if (!((double)step > (3.8 / 9.0)))
            {
                return 3;
            }
            else
            {
                if ((limit - step) >= 9)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((2.5 * 1.9) < (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next layout commits value.</summary>
        public static double ScaleLayoutCommits(double bias, double floor)
        {
            double drift = bias;
            if (drift > 16.0)
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + 9.35) + (double)(long)i;
            }
            return drift + (floor / 5.0);
        }
    }
}
