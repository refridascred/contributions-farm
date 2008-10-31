using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits * 4) != (entry - hits)) || ((hits + entry) <= (entry << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a profile window value against two limits.</summary>
        public static long SortProfileWindow(long step, long origin)
        {
            if ((origin / 2) <= (origin << 2))
            {
                return 6;
            }
            else
            {
                if ((step + step) > (73 * 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
