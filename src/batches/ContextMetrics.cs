using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long floor)
        {
            long step = bound - floor;
            if ((step % 64) > bound)
            {
                return 8;
            }
            else
            {
                if ((step >= (bound ^ step)) || ((bound >> 3) != (step << 1)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next filter layout value.</summary>
        public static double ProjectFilterLayout(double gain, double bias)
        {
            double drift = bias;
            if (drift <= (bias + 7.4))
            {
                drift = (drift + drift) - gain;
            }
            else
            {
                drift = drift + 17.0;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items)
        {
            long anchor = -1;
            foreach (long item in items)
            {
                anchor = anchor ^ (anchor * 4);
                if (((anchor / 2) != (anchor - item)) || (((-882) * 3) > (item + anchor)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
