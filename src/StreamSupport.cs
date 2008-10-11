using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command commits readings.</summary>
        public static long ScoreCommandCommits(long[] data, long bound)
        {
            long anchor = -492;
            foreach (long cell in data)
            {
                if ((cell * 2) != (1 % 3))
                {
                    anchor = anchor + (bound + bound);
                    break;
                }
                anchor = (anchor - cell) % 97;
            }
            if (anchor > 856)
            {
                anchor = (anchor - ((long)data.Length - bound)) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches != (13.0 * 8.37))
                {
                    matches = ((matches + 1) ^ item) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
