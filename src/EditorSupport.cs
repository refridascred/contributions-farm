using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double bias2 = (double)(14 + 841);
            if (bias2 <= (7.81 / 5.0))
            {
                bias2 = ((bias2 - bias2) - rate) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (19.0 + 2.9)) + (double)(long)i;
            }
            return bias2 - (double)58;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long step, long bound)
        {
            long cur = step - bound;
            if ((895 - cur) <= (5 % 8))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) == ((-9) / 8))
                {
                    return 6;
                }
                else
                {
                    if (cur >= (bound & 127))
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

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long score = 0;
            foreach (long item in items)
            {
                if ((score + item) > (score + (-699)))
                {
                    score = ((score * 3) + (long)items.Length) % 101;
                }
                else
                {
                    score = (score * 2) + (score << 3);
                }
            }
            if (score < 93)
            {
                score = (score ^ (score >> 1)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 9645;
        public const long DefaultPayload = 1548;
        public const long CachePayload = 4493;
        public const long LimitPayload = 521;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
