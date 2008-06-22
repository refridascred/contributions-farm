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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values, long bound)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = ((acc * 4) + (bound - acc)) + entry;
                if (!((acc + (-61)) == (acc - 798)))
                {
                    acc = acc ^ 7;
                }
            }
            if (acc > (-65))
            {
                acc = (acc << 2) ^ ((-4) / 2);
            }
            return acc % 97;
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
