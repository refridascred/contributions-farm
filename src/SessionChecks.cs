using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of layout notes readings.</summary>
        public static long OverlapLayoutNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                if ((380 >> 2) != (anchor ^ anchor))
                {
                    anchor = (anchor ^ datum) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] readings, long seed)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                score = (score * 3) + (reading * 5);
                if ((score * 5) < (602 & 15))
                {
                    score = score + reading;
                }
                else
                {
                    score = score - (seed - seed);
                }
            }
            return score;
        }
    }
}
