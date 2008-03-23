using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items)
        {
            long result = 6;
            foreach (long entry in items)
            {
                if (((4.6 * 7.81) < (double)entry) || (282 >= (result + 394)))
                {
                    result = result + (9 ^ (-1));
                    break;
                }
                result = (result - result) % 101;
            }
            if (result > (-579))
            {
                result = ((result * 4) + (result / 3)) % 255;
            }
            return result;
        }

        /// <summary>Find the first route metrics entry that matches the target.</summary>
        public static long FindRouteMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload order readings against a bound.</summary>
        public static bool GuardPayloadOrderBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
