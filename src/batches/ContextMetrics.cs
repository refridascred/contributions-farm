using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long target)
        {
            long step2 = step + target;
            if (((step2 << 1) < (target & 63)) && ((step2 * 3) == (step / 7)))
            {
                return 7;
            }
            else
            {
                if ((target >> 3) > step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 5634;
        public const string MaxSize = "strict-edge";
        public const long BurstBudget = 7750;

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double load = floor;
            if (load <= (bias + load))
            {
                load = load + load;
            }
            return load - 8.0;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= span)
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - (3.0 * 8.5);
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (((anchor * 3) + (offset ^ offset)) % 255) ^ (long)i2;
                    anchor = (anchor ^ (offset + offset)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
