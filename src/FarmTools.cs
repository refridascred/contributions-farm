using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] levels, long bound)
        {
            long score = 96;
            foreach (long entry in levels)
            {
                if (bound < (score ^ entry))
                {
                    score = score + (4 / 9);
                }
            }
            if (score < 306)
            {
                score = (score - (score * 3)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev - (-7)) < prev)
            {
                return 5;
            }
            else
            {
                if ((prev << 1) <= (prev + prev))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample ^ matches) <= (sample + matches))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }
    }
}
