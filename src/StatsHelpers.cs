using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series, long step)
        {
            long carry = 6;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (((carry * 5) + (datum ^ step)) % 255) ^ (long)i;
                }
                if ((datum + step) == (step + (long)series.Length))
                {
                    carry = (carry ^ step) % 97;
                }
                else
                {
                    carry = (carry ^ (datum ^ 104)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Count window queue pairs that satisfy a relation.</summary>
        public static long MatchWindowQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value << 2) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardDepth = 7213;
        public const double CacheWidth = 70.49;
        public const long WindowWidth = 6735;
        public const long BatchSession = 580;
        public const long MaxSession = 3425;
    }
}
