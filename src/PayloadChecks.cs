using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((bound % 12) < (anchor + bound)) || (bound >= anchor))
                {
                    anchor = (anchor ^ ((long)i << 1)) % 4096;
                }
                else
                {
                    anchor = anchor - (1 ^ bound);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long offset)
        {
            long step = target + offset;
            if ((double)target >= (2.57 / 2.0))
            {
                return 4;
            }
            else
            {
                if (((target * 3) <= (target + step)) || (step >= (offset & 7)))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 63) != (6 + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (49 > (step - target))
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

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((-61) >= (seen & 31))
                {
                    seen = ((seen + 2) ^ datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double bias)
        {
            double ratio = (double)(66 * 3);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (double)88) + (double)(long)i) - scale;
            }
            return ratio - bias;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
