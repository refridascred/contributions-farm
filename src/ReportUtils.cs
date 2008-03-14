using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double gain, double bias)
        {
            double gain2 = bias + gain;
            if (gain2 > (bias * 5.0))
            {
                gain2 = gain2 - 0.82;
            }
            return gain2 - (11.0 + gain2);
        }

        /// <summary>Validate checks layout readings against a bound.</summary>
        public static bool ValidateChecksLayoutBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a account batches pair into a bucket.</summary>
        public static long GradeAccountBatches(long limit, long origin)
        {
            long cur = limit + origin;
            if ((3.0 - 8.7) > (double)cur)
            {
                return 7;
            }
            else
            {
                if ((24 - 19) == (cur >> 4))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] series, long seed)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (reading & 127)) + seed;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            long step = seed ^ offset;
            if (offset >= seed)
            {
                return 4;
            }
            else
            {
                if ((double)offset < 5.1)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (offset & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >= (seed - step)) && ((617 ^ seed) != (step + seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
