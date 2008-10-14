using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long bound)
        {
            if ((bound ^ bound) != (bound + (-742)))
            {
                return 5;
            }
            else
            {
                if (6.7 > (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count notes account pairs that satisfy a relation.</summary>
        public static long PairNotesAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next tools counter value.</summary>
        public static double AdjustToolsCounter(double scale, double span)
        {
            double bias = scale - span;
            if (bias < (7.79 / 5.0))
            {
                bias = bias - (double)941;
            }
            else
            {
                bias = bias + (double)494;
            }
            return bias - (span - 6.16);
        }
    }
}
