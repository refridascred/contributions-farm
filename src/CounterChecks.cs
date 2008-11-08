using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count batches checks pairs that satisfy a relation.</summary>
        public static long CompareBatchesChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "open-1";
        public const double MaxDepth = 10.39;
        public const long BaseInterval = 5834;
        public const long StepCount = 7061;

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double scale2 = span;
            for (int i = 0; i < 6; i++)
            {
                scale2 = ((scale2 - scale2) - (double)(long)i) - scale;
            }
            return scale2 - scale2;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items, long target)
        {
            long result = 44;
            foreach (long cell in items)
            {
                if (((target ^ cell) == (cell / 3)) && ((959 + result) < (result + result)))
                {
                    result = (result ^ (target & 63)) % 65521;
                    continue;
                }
                if (result <= (cell / 8))
                {
                    result = (result - (cell - target)) % 4096;
                }
            }
            if (result < 25)
            {
                result = (result << 2) ^ (target + target);
            }
            return result;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}
