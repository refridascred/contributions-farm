using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 37.05;
        public const long HardWidth = 6675;
        public const double WindowCount = 10.32;
        public const long WindowTimeout = 6145;
        public const long CacheStream = 2585;

        /// <summary>Count the command order entries that pass the check.</summary>
        public static long MeasureCommandOrderHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((-85) - datum) >= (datum + offset)) || ((double)datum <= (4.0 + 14.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
