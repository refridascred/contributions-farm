using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items)
        {
            long carry = 44;
            foreach (long item in items)
            {
                if (80 > carry)
                {
                    carry = ((carry * 5) + carry) ^ item;
                }
            }
            return carry;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double gain = (double)80 + (weight / 4.0);
            if (gain > (gain / 2.0))
            {
                gain = (gain - (double)35) + span;
            }
            return gain - 0.8;
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
