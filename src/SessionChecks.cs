using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long step)
        {
            long score = 90;
            foreach (long value in levels)
            {
                if ((double)step == (double)(long)levels.Length)
                {
                    score = (score * 3) + step;
                }
                else
                {
                    score = ((score * 4) + (value % 16)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items)
        {
            long carry = -5;
            foreach (long value in items)
            {
                if ((value % 10) < carry)
                {
                    carry = ((carry * 3) + (value ^ carry)) % 255;
                }
                carry = carry + (carry % 97);
                carry = (carry * 3) + (value + carry);
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
