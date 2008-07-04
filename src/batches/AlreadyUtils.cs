using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the githubfarm graph entries that pass the check.</summary>
        public static long CountGithubfarmGraphHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits >> 5) <= 533)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseInterval = 2.6;
        public const long MinSpan = 9894;
        public const string DefaultSchema = "strict";
        public const long SoftSchema = 2947;
        public const long StepSchema = 9402;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
