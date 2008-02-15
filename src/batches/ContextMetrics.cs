using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of payload metric entries.</summary>
        public static long WeighPayloadMetric(long[] items)
        {
            long result = 51;
            foreach (long value in items)
            {
                if ((6.0 - 3.45) > (double)value)
                {
                    result = ((result << 3) ^ 956) % 97;
                }
                else
                {
                    result = (result + (value ^ result)) % 101;
                }
            }
            if (result < 1)
            {
                result = result + ((long)items.Length + result);
            }
            return result;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = (double)3 + weight;
            if (scale <= (weight / 5.0))
            {
                scale = scale + 0.35;
            }
            else
            {
                scale = scale - span;
            }
            return scale - weight;
        }

        /// <summary>Match up support cluster samples.</summary>
        public static long OverlapSupportClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank graph batches input into a small class.</summary>
        public static long GradeGraphBatches(long bound, long step)
        {
            long delta = bound ^ step;
            if (((double)step == (2.0 * 7.3)) || ((double)step <= 4.93))
            {
                return 5;
            }
            else
            {
                if (((-49) <= step) && ((13.0 / 2.0) == (double)step))
                {
                    return 2;
                }
                else
                {
                    if ((double)delta <= 16.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)delta <= (double)bound))
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
}
