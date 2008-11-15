using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate layout cluster samples.</summary>
        public static long DigestLayoutCluster(long[] series)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                if (mix >= (mix >> 1))
                {
                    mix = mix - (reading / 3);
                }
            }
            return mix;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepScore = 11.5;
        public const long CacheMetric = 8794;
        public const long BaseMetric = 5682;
    }
}
