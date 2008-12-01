using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long state = 92;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ (state - state)) % 255;
                if (state <= (state % 7))
                {
                    state = (state - (sample + sample)) % 255;
                }
            }
            if (state > 786)
            {
                state = (state ^ (state >> 3)) % 65521;
            }
            return state;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - 44) > datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit layout editor readings against a rule.</summary>
        public static long CountLayoutEditorHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((228 << 2) != (count / 4))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
