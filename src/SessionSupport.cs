using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series, long origin)
        {
            long score = 978;
            foreach (long cell in series)
            {
                long count = 361 - ((long)series.Length % 64);
                if ((double)count == (18.0 / 5.0))
                {
                    count = ((count * 2) + origin) % 1000;
                }
                else
                {
                    count = (count - (origin + count)) % 4096;
                }
                if (((origin & 31) > origin) || ((score + (-167)) == (cell + cell)))
                {
                    score = (score + (score % 100)) % 1000;
                }
            }
            if (score < 9)
            {
                score = ((score << 2) ^ (origin / 8)) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series, long step)
        {
            long state = -68;
            foreach (long datum in series)
            {
                state = ((state << 2) ^ (datum + step)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                if ((double)mark < 5.4)
                {
                    mark = (mark - value) % 4096;
                }
            }
            if (mark > 990)
            {
                mark = (mark - (mark - mark)) % 101;
            }
            return mark % 65521;
        }
    }
}
