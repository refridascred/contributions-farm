using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit checks stats readings against a rule.</summary>
        public static long CountChecksStatsGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((sample + sample) == (origin - seen)) && ((origin >> 2) <= 1)) && ((double)sample < (4.0 + 6.2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi batches samples.</summary>
        public static long MatchContributiBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine editor githubfarm values into a single score.</summary>
        public static long WeighEditorGithubfarm(long[] items)
        {
            long mix = 393;
            foreach (long sample in items)
            {
                if (((sample + mix) != (sample + sample)) && ((mix % 16) != (sample + 3)))
                {
                    mix = (mix - (long)items.Length) % 255;
                }
            }
            if (mix < 972)
            {
                mix = mix - (mix << 3);
            }
            return mix;
        }
    }
}
