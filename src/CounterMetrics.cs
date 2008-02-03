using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] items, long step)
        {
            long mix = 635;
            foreach (long sample in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix + ((long)items.Length ^ (-206))) % 1000) ^ (long)i;
                }
                if (step <= (sample + mix))
                {
                    mix = ((mix << 2) ^ (521 / 3)) % 101;
                }
                if ((mix + step) > (37 / 2))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
