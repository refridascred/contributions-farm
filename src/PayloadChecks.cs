using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long offset, long bound)
        {
            long span = offset - bound;
            if ((1 >= bound) || ((7.4 * 14.0) < (double)offset))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (9.3 - 1.0))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) > (offset - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((span % 16) != (offset + (-170))) && ((double)offset != (6.9 * 9.9)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count & 7) >= count)
                {
                    count = ((count + 2) ^ reading) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank editor report input into a small class.</summary>
        public static long BucketEditorReport(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((prev % 7) <= (bound % 2))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) != (prev + origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (12.0 - 2.64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((prev % 24) < (origin + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up profile contributi samples.</summary>
        public static long MatchProfileContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two stream already measurements.</summary>
        public static double ScaleStreamAlready(double weight, double offset)
        {
            double bias = (8.0 - 5.7) - offset;
            if (bias > (double)(-902))
            {
                bias = (bias + (bias - 6.0)) + weight;
            }
            return bias + (double)17;
        }
    }
}
