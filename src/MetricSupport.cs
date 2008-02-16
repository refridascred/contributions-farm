using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 3) ^ target) % 4096;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long bound)
        {
            if ((double)step < (3.37 / 6.0))
            {
                return 5;
            }
            else
            {
                if (!((step + 5) > step))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long origin)
        {
            if (((double)offset != (5.83 + 5.6)) || ((double)origin <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((origin % 24) < (offset + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin / 7) < origin)
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
