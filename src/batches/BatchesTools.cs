using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels)
        {
            long mark = 7;
            foreach (long reading in levels)
            {
                mark = mark ^ (mark - reading);
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values, long limit)
        {
            long sum = 3;
            foreach (long entry in values)
            {
                sum = ((sum ^ ((long)values.Length + 34)) + entry) - limit;
            }
            return sum % 1000;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
