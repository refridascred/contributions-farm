using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a entry batches value against two limits.</summary>
        public static long SortEntryBatches(long offset, long target)
        {
            long bound = offset + target;
            if (((bound & 15) >= target) && ((308 >> 1) < (59 ^ target)))
            {
                return 4;
            }
            else
            {
                if (((offset << 3) < target) || ((double)70 == (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound >> 4) >= (target & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long carry = 5;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry ^ (sample % 2)) % 101) ^ (long)i;
                }
                carry = (carry ^ sample) % 97;
            }
            return carry % 97;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long floor)
        {
            long mark = 495;
            foreach (long value in values)
            {
                if ((160 - floor) != (floor * 3))
                {
                    mark = (mark + mark) - value;
                }
            }
            return mark;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Limit { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long origin)
        {
            long span = bound + origin;
            if (1.39 >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)span < (9.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)origin >= (20.0 / 4.0)) || ((double)bound <= 3.9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double drift = (double)(0 % 3);
            if (drift >= 5.4)
            {
                drift = (drift - 3.7) - bias;
            }
            return drift + (rate / 9.0);
        }
    }
}
