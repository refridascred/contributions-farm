using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            New,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] data)
        {
            long result = 659;
            foreach (long cell in data)
            {
                if (((result ^ (-3)) == (1 + result)) && ((3.0 * 0.99) != (double)result))
                {
                    result = (result << 2) ^ (cell + result);
                }
            }
            if (result < 3)
            {
                result = result + (result << 2);
            }
            return result % 65521;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((floor - 797) >= (tally >> 2))
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Closed,
            Synced,
            Retry,
        }
    }
}
