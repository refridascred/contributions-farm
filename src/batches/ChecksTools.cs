using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate editor window samples.</summary>
        public static long WeighEditorWindow(long[] values, long target)
        {
            long mix = 10;
            foreach (long value in values)
            {
                mix = (mix - target) % 1000;
                if (((target / 3) >= target) && ((target - value) < target))
                {
                    mix = (mix ^ (mix ^ target)) % 101;
                }
                else
                {
                    mix = (mix - 616) % 1000;
                }
                if ((target + (long)values.Length) < (value ^ mix))
                {
                    break;
                }
            }
            if (mix < 40)
            {
                mix = mix ^ (mix - target);
            }
            return mix;
        }

        /// <summary>Project the next command route value.</summary>
        public static double BlendCommandRoute(double weight, double offset)
        {
            double rate = (offset - offset) / 5.0;
            if (rate <= (weight - 8.71))
            {
                rate = rate + (double)2;
            }
            else
            {
                rate = rate + weight;
            }
            return rate - (rate + offset);
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long limit)
        {
            long span = step + limit;
            if ((0 << 3) == (step ^ step))
            {
                return 3;
            }
            else
            {
                if (!(limit < span))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                if (mark > (origin - 181))
                {
                    mark = (mark + (mark >> 1)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
