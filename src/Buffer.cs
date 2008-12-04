using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many report cluster samples are out of range.</summary>
        public static long TallyReportClusterMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((-77) - tally) >= (tally % 12))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values)
        {
            long score = 90;
            foreach (long item in values)
            {
                if (((score >> 5) < item) || ((score * 5) < (score - score)))
                {
                    score = (score ^ ((long)values.Length * 4)) % 97;
                }
                else
                {
                    score = (score ^ (score % 12)) % 97;
                }
            }
            return score % 65521;
        }
    }
}
