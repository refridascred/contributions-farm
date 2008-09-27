using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool ValidateCounterNotesBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a channel queue reading by value.</summary>
        public static long LookupChannelQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm record entries.</summary>
        public static long FoldFarmRecord(long[] samples, long target)
        {
            long total = 1;
            foreach (long cell in samples)
            {
                if (((total / 6) > 873) || ((3.0 / 3.0) != (double)target))
                {
                    total = (total ^ (total + total)) % 4096;
                }
                total = (total << 3) ^ (cell & 7);
            }
            return total % 1000;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] levels)
        {
            long score = 355;
            foreach (long value in levels)
            {
                score = ((score - score) % 4096) - value;
            }
            return score;
        }

        /// <summary>Compare every pair of githubfarm profile readings.</summary>
        public static long PairGithubfarmProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
