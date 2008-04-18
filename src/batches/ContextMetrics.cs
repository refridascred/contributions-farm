using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 4762;
        public const long IdleDepth = 173;
        public const long DefaultInterval = 4155;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] values, long step)
        {
            long mark = -6;
            foreach (long datum in values)
            {
                if ((datum - mark) == (datum - (long)values.Length))
                {
                    mark = ((mark + (mark << 3)) % 65521) - step;
                }
                if ((double)datum < (18.0 * 2.82))
                {
                    mark = (mark << 3) ^ (7 * 3);
                }
            }
            return mark;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum ^ (sum - sum)) % 101) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a layout queue counter forward.</summary>
        public static long StepLayoutQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state ^ (state & 7)) % 97;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double rate = (double)20;
            if (rate < ratio)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
