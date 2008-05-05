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

        /// <summary>Count the tools checks entries that pass the check.</summary>
        public static long MeasureToolsChecksHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((origin + 3) == (origin / 8)) || (((long)values.Length ^ origin) >= matches))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
