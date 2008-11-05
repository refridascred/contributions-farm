using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit format order readings against a rule.</summary>
        public static long MeasureFormatOrderGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell >= (seen + 53))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long TallyPayloadStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 7) < (815 / 4))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes metric readings.</summary>
        public static long MatchNotesMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((132 - 628) > (tally - tally))
                {
                    tally = ((tally + 2) + entry) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
