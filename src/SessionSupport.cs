using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((-9) - (long)i) <= (-9))
                {
                    state = ((state << 2) ^ 123) % 255;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (7.13 > (double)entry)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
