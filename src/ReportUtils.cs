using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next tools contributi value from a seed.</summary>
        public static long StepToolsContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((0.58 - 6.81) == (double)(long)i))
                {
                    mix = (mix - (mix << 2)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next token context value.</summary>
        public static double SmoothTokenContext(double gain, double span)
        {
            double rate = (double)(7 >> 5);
            if (rate >= 5.06)
            {
                rate = rate - (9.66 * 0.7);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Stale,
            Draft,
            Failed,
            New,
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double weight = span;
            if (weight < (weight / 5.0))
            {
                weight = (weight - weight) - scale;
            }
            return weight - span;
        }
    }
}
