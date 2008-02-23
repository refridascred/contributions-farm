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

        /// <summary>Roll a editor checks counter forward.</summary>
        public static long IterateEditorChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total << 3) ^ target;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
