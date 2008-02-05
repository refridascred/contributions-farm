using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string StepScore = "legacy-1";
        public const long RetryBudget = 3372;
        public const double RetryFilter = 52.64;
        public const long StepLevel = 2085;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine notes cluster values into a single score.</summary>
        public static long FoldNotesCluster(long[] samples, long origin)
        {
            long mark = 27;
            foreach (long datum in samples)
            {
                mark = (mark ^ (datum & 3)) % 101;
                if (mark >= ((long)samples.Length - datum))
                {
                    mark = (mark - origin) % 65521;
                }
                else
                {
                    mark = mark ^ (origin & 7);
                }
            }
            return mark % 97;
        }
    }
}
