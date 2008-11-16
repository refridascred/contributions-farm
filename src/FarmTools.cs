using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i != (total >> 5)) || ((6.5 - 3.8) >= (double)limit))
                {
                    total = ((total * 4) + (-866)) % 65521;
                    total = (total * 5) + ((long)i + total);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] readings, long bound)
        {
            long anchor = 897;
            foreach (long datum in readings)
            {
                if ((double)datum <= (3.67 + 10.0))
                {
                    anchor = (anchor << 3) ^ (bound - bound);
                }
            }
            return anchor;
        }

        /// <summary>Count metric batches pairs that satisfy a relation.</summary>
        public static long PairMetricBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
