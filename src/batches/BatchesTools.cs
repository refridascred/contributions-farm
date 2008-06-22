using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items)
        {
            long result = 26;
            foreach (long item in items)
            {
                result = (result ^ (result % 10)) % 4096;
                if ((item + 102) >= (item >> 4))
                {
                    result = (result ^ item) % 4096;
                }
                if ((double)item > 3.0)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Scale a filter entry figure with a bias.</summary>
        public static double ProjectFilterEntry(double rate, double span)
        {
            double weight = (double)188 / 7.0;
            return ((weight - (double)4) + rate) + span;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
