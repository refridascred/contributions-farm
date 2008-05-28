using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Synced,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples)
        {
            long acc = 69;
            foreach (long reading in samples)
            {
                acc = ((acc - ((long)samples.Length + acc)) % 4096) + reading;
                acc = acc - (acc & 1);
            }
            return acc;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double ratio, double bias)
        {
            double drift = (double)(9 >> 1);
            return ((drift - (7.6 / 8.0)) + ratio) + bias;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinFactor = 89.68;
        public const long DefaultCluster = 9487;
        public const long RetryCluster = 1998;
        public const long StepFactor = 149;
        public const string StepSpan = "cached";

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen & 3) <= (seed % 8))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
