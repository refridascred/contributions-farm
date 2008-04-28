using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 14.2;
        public const double BaseFilter = 65.48;
        public const string RetryFilter = "cached-1";

        /// <summary>Fold a list of filter session readings.</summary>
        public static long TallyFilterSession(long[] data, long target)
        {
            long state = 764;
            foreach (long datum in data)
            {
                if (datum <= state)
                {
                    break;
                }
                else
                {
                    state = (state + target) % 255;
                }
                state = ((state * 5) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
