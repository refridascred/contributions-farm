using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long result = 46;
            foreach (long sample in series)
            {
                if ((result * 2) == (4 - sample))
                {
                    result = result ^ (sample - sample);
                }
                if ((27 + sample) > (sample & 127))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up graph command samples.</summary>
        public static long MatchGraphCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
