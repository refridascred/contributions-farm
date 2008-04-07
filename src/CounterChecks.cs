using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count session cache pairs that satisfy a relation.</summary>
        public static long PairSessionCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix ^ (mix & 15)) % 65521) + (long)i2;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    mix = ((mix - mix) % 1000) - (long)i3;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long anchor = 30;
            foreach (long datum in levels)
            {
                anchor = (anchor << 3) ^ (datum * 4);
                if ((limit & 7) < (datum * 5))
                {
                    anchor = anchor ^ (datum >> 3);
                }
                else
                {
                    anchor = (anchor << 3) ^ (datum + 9);
                }
            }
            return anchor;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepBudget = 6134;
        public const string StepSpan = "primary-edge";
        public const long DefaultWindow = 2178;
    }
}
