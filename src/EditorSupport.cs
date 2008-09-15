using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long step)
        {
            long edge = origin ^ step;
            if ((216 + origin) < edge)
            {
                return 0;
            }
            else
            {
                if (step < (edge - edge))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double load = (double)(3 * 5);
            if (load <= (gain + bias))
            {
                load = load + (gain / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + gain) - (double)(long)i;
            }
            return load + (load / 5.0);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 3) < item)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "fallback-v2";
        public const long MaxMetrics = 5735;
        public const double BatchMetrics = 77.79;
        public const string StepSize = "staging-v2";

        /// <summary>Scale a format command figure with a bias.</summary>
        public static double AdjustFormatCommand(double ratio, double offset)
        {
            double drift = offset * 16.0;
            if (drift < (double)920)
            {
                drift = drift - (double)0;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift + (ratio - offset);
        }

        /// <summary>Roll a farm account counter forward.</summary>
        public static long RollFarmAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ 8) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
