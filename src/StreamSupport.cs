using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (1.3 - 3.5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up payload githubfarm samples.</summary>
        public static long OverlapPayloadGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
