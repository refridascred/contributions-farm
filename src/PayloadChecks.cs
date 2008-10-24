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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((state ^ state) > (seed % 12))
                {
                    state = (state - (state << 1)) % 101;
                }
                else
                {
                    state = (state ^ ((long)i % 60)) % 255;
                    state = (state + ((long)i & 63)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
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
