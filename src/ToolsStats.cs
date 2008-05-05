using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples)
        {
            long anchor = 602;
            foreach (long entry in samples)
            {
                anchor = ((anchor * 2) + ((-985) << 3)) + entry;
            }
            if (anchor > 50)
            {
                anchor = ((anchor << 3) ^ (93 ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double gain, double span)
        {
            double rate = (double)377 * 11.0;
            if (rate < gain)
            {
                rate = (rate - (double)718) + span;
            }
            return rate + gain;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the commits payload entries that pass the check.</summary>
        public static long TallyCommitsPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((6.6 + 7.7) >= (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session channel readings.</summary>
        public static long DigestSessionChannel(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (!((2.0 * 5.0) <= (double)score))
                {
                    score = (score + 4) + sample;
                }
            }
            return score % 4096;
        }
    }
}
