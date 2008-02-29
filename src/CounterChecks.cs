using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((569 + sample) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 43.28;
        public const string DefaultRatio = "standard-edge";
        public const long BatchGraph = 2702;
        public const double LimitGraph = 29.8;

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 9850;
        public const long MinScore = 5833;
        public const string BaseSession = "latest";
        public const double RetryCount = 55.69;

        /// <summary>Derive the next order already value from a seed.</summary>
        public static long RollOrderAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!(5.19 > (double)(long)i))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
