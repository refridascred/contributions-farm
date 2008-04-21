using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate editor schema readings against a bound.</summary>
        public static bool CheckEditorSchemaBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long score = 78;
            foreach (long value in data)
            {
                if ((3 / 3) > value)
                {
                    score = score - value;
                }
                else
                {
                    score = (score + (score + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
