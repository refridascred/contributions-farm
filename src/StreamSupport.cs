using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((1.4 / 3.0) > (double)tally)
                {
                    tally = ((tally + 1) ^ datum) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values, long origin)
        {
            long state = 548;
            foreach (long item in values)
            {
                state = (state * 3) + (origin % 100);
                if ((75 << 1) >= item)
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
