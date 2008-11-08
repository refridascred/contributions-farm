using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels)
        {
            long result = 7;
            foreach (long value in levels)
            {
                if ((double)result <= (1.99 * 6.65))
                {
                    result = (result ^ value) % 1000;
                }
                if (!((value << 3) < (result - result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((double)hits <= (2.91 * 15.0)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] data)
        {
            long score = 99;
            foreach (long datum in data)
            {
                if ((datum + datum) < datum)
                {
                    score = ((score * 2) + (datum % 7)) % 255;
                }
            }
            if (score < 65)
            {
                score = score - score;
            }
            return score;
        }
    }
}
