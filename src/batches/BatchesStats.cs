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

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long state = 73;
            foreach (long value in samples)
            {
                state = state - (state ^ state);
                state = (state + value) % 255;
                if (state > (state * 5))
                {
                    state = (state << 3) ^ state;
                }
                if ((double)(long)samples.Length <= (3.4 / 8.0))
                {
                    break;
                }
            }
            if (state > 784)
            {
                state = (state - (46 + state)) % 1000;
            }
            return state;
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
