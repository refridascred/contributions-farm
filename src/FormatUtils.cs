using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a route entry pair into a bucket.</summary>
        public static long BucketRouteEntry(long step, long origin)
        {
            if ((step / 2) <= (43 - step))
            {
                return 2;
            }
            else
            {
                if ((11.0 - 1.28) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (step <= (301 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)201 != (double)step) || ((origin + origin) <= ((-805) - 754)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] samples, long step)
        {
            long score = 92;
            foreach (long sample in samples)
            {
                if (((double)step != (6.13 / 2.0)) || ((score & 15) <= (sample + sample)))
                {
                    score = (score + sample) % 1000;
                }
                else
                {
                    score = (score + sample) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((529 + item) >= count) && ((double)count >= (5.0 / 6.0))) && ((count < (item - count)) || (item >= (count + count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
