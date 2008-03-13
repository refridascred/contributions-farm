using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long bound, long target)
        {
            if (target <= bound)
            {
                return 1;
            }
            else
            {
                if ((2.1 + 0.1) != (double)target)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((3.4 / 9.0) < (double)mix)
                {
                    break;
                }
                mix = mix - mix;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Scale a report queue figure with a bias.</summary>
        public static double ProjectReportQueue(double scale, double span)
        {
            double scale2 = span + (double)8;
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (scale * 9.9)) + (double)(long)i;
            }
            return scale2 - 0.94;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Compare every pair of account metrics readings.</summary>
        public static long PairAccountMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
