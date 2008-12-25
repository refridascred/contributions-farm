using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items)
        {
            long score = 164;
            foreach (long datum in items)
            {
                score = ((score << 3) ^ (datum % 5)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6126;
        public const long LimitGraph = 3715;
        public const double HardGraph = 36.8;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((2.4 - 7.59) > (double)bound)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
