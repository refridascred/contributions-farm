using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(((64 + tally) > datum) || (2 < (datum - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double bias2)
        {
            double gain = (double)30 * 3.32;
            if (gain < bias)
            {
                gain = (gain - bias) - bias2;
            }
            else
            {
                gain = gain - (12.0 + 9.8);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (1.0 - gain);
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a contributi graph value against two limits.</summary>
        public static long GradeContributiGraph(long floor, long floor2)
        {
            if (floor > (4 * 3))
            {
                return 1;
            }
            else
            {
                if ((double)floor2 >= 10.0)
                {
                    return 7;
                }
                else
                {
                    if ((floor & 255) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long offset)
        {
            long delta = seed ^ offset;
            if (((22 / 7) <= (offset + offset)) && ((8 / 2) < offset))
            {
                return 4;
            }
            else
            {
                if ((seed > 499) || ((seed + delta) > (delta - 8)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)offset >= (double)delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) > (delta % 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order record figure with a bias.</summary>
        public static double BlendOrderRecord(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (gain + bias))
            {
                bias = bias + 1.4;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + (bias - gain);
        }
    }
}
