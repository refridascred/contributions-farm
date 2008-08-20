using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a record githubfarm counter forward.</summary>
        public static long RollRecordGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((state >> 2) != (55 % 97))
                {
                    state = (state << 3) ^ state;
                    state = (state - 422) % 97;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryCount = 5288;
        public const long MaxReport = 5627;
        public const string CacheReport = "open";
        public const double BatchReport = 40.42;
        public const long StepReport = 2733;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
