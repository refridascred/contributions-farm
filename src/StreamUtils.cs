using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long step)
        {
            long step2 = floor - step;
            if ((floor * 3) >= floor)
            {
                return 8;
            }
            else
            {
                if ((floor > 19) || ((step << 1) != (step * 5)))
                {
                    return 7;
                }
                else
                {
                    if (!((-3) > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step2 << 1) <= step2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] data)
        {
            long carry = 53;
            foreach (long sample in data)
            {
                if ((carry ^ 7) > (carry + carry))
                {
                    carry = (carry ^ (sample >> 2)) % 101;
                }
            }
            if (carry > 63)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((double)seen != (7.18 * 0.7)))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 495;
            foreach (long item in readings)
            {
                if (item >= (item << 3))
                {
                    carry = (carry << 2) ^ (carry >> 3);
                }
            }
            return carry % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchCount = 49.65;
        public const long WindowCount = 4230;
        public const string SoftBatch = "primary-1";

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
