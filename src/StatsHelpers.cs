using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftBudget = 8124;
        public const double IdleSpan = 66.32;
        public const long HardCommand = 9431;
        public const string LimitCommand = "standard";
        public const long RetryWidth = 9342;

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long step)
        {
            if ((double)step > 9.41)
            {
                return 8;
            }
            else
            {
                if ((floor << 3) == (step - floor))
                {
                    return 5;
                }
                else
                {
                    if (((floor + step) > 253) || ((0.28 - 1.0) > (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step < (5.1 * 2.9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
