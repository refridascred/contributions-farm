using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items)
        {
            long anchor = 237;
            foreach (long cell in items)
            {
                anchor = ((anchor << 3) ^ (anchor - (long)items.Length)) - cell;
            }
            if (anchor > 9)
            {
                anchor = (anchor - (anchor >> 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((origin >= (origin / 6)) && (((double)origin <= (7.2 * 1.94)) && ((double)origin <= 8.92)))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next command queue value from a seed.</summary>
        public static long DeriveCommandQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a layout context reading by value.</summary>
        public static long FindLayoutContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
