using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double rate = bias;
            return (rate + (double)39) + gain;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the tools payload series from a seed.</summary>
        public static long SeriesToolsPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = state + (state % 5);
                state = state ^ (limit % 7);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
