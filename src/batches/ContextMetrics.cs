using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSize = 2182;
        public const long HardFactor = 6265;
        public const long RetryStats = 4213;
        public const long MinCount = 8756;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Pending,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Compare every pair of batches account readings.</summary>
        public static long OverlapBatchesAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings, long limit)
        {
            long result = 88;
            foreach (long sample in readings)
            {
                if (!((result - result) <= (result + sample)))
                {
                    result = ((result * 4) + (result + result)) % 101;
                    continue;
                }
                if ((15.0 + 3.0) != (double)sample)
                {
                    result = (result << 3) ^ (sample & 3);
                }
            }
            if (result > 4)
            {
                result = (result ^ (limit + result)) % 4096;
            }
            return result;
        }

        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long CountWindowNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8.2 - 3.7) != (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
