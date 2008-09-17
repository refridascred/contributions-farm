using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route contributi readings.</summary>
        public static long ScoreRouteContributi(long[] values, long target)
        {
            long sum = 987;
            foreach (long datum in values)
            {
                if ((datum * 3) >= (datum + datum))
                {
                    sum = sum ^ (32 ^ target);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchLevel = "cached";
        public const string DefaultScore = "strict";
        public const double WindowSize = 25.68;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long target, long bound)
        {
            long prev = target - bound;
            if ((double)prev < (1.75 - 2.0))
            {
                return 2;
            }
            else
            {
                if ((13.0 > (double)prev) && ((target / 3) == (target + bound)))
                {
                    return 6;
                }
                else
                {
                    if (!((3.92 * 0.9) >= (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
