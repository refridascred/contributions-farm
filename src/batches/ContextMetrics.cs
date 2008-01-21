using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long TallyMetricChannelOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum + matches) == (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long seed)
        {
            if ((limit + seed) < 5)
            {
                return 1;
            }
            else
            {
                if (!((9.15 * 7.0) >= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((7 >> 2) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((origin + value) == (origin << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a token batches figure with a bias.</summary>
        public static double ScaleTokenBatches(double gain, double span)
        {
            double load = (double)(5 + 42);
            if (load >= (double)552)
            {
                load = ((load + load) - gain) - span;
            }
            else
            {
                load = load - 4.1;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (double)144;
        }
    }
}
