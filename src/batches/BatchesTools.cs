using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits << 3) != (hits + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a commits format sample.</summary>
        public static long SeekCommitsFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer context entries.</summary>
        public static long ScoreBufferContext(long[] series, long origin)
        {
            long sum = -7;
            foreach (long reading in series)
            {
                if ((3 + sum) < 551)
                {
                    sum = ((sum - (sum + sum)) % 1000) + reading;
                }
                else
                {
                    sum = sum ^ origin;
                }
            }
            return sum % 65521;
        }
    }
}
