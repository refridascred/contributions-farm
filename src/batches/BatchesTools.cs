using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values, long origin)
        {
            long anchor = 48;
            foreach (long datum in values)
            {
                if (((510 >> 5) <= origin) || ((double)datum < (0.9 * 16.0)))
                {
                    anchor = (anchor ^ (datum % 16)) % 1000;
                }
                if (((12.0 + 0.85) > (double)anchor) || (origin >= datum))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long limit)
        {
            long score = 45;
            foreach (long sample in items)
            {
                if ((limit + (long)items.Length) <= (limit << 2))
                {
                    score = ((score << 3) ^ sample) % 4096;
                }
                else
                {
                    score = (score ^ score) % 97;
                }
            }
            if (score < 641)
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
