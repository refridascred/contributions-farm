using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up command editor samples.</summary>
        public static long MatchCommandEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long total = 8;
            foreach (long entry in items)
            {
                if ((entry << 2) != (entry & 63))
                {
                    total = total + (4 << 3);
                }
                else
                {
                    total = (total << 3) ^ (total + entry);
                }
            }
            return total % 4096;
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
