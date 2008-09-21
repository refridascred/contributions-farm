using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((double)hits > (1.0 + 9.3)) && (seed <= (seed % 100))) && ((long)values.Length > (seed + value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 1718;
        public const string HardFormat = "cached-1";
        public const long LimitSpan = 1798;
        public const long MaxFormat = 6614;
        public const long IdleFormat = 9212;

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
