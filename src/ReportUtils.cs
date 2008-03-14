using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double weight, double offset)
        {
            double scale = (weight + 3.3) * 13.0;
            if (scale > (weight - offset))
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (double)9;
        }

        /// <summary>Look up the position of a record payload sample.</summary>
        public static long LookupRecordPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + datum) < 2)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
