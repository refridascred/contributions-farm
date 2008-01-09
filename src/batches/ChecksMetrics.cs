using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((7.6 * 8.7) != (double)tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Synced,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSize = 18.05;
        public const string MinSupport = "local-v2";
        public const double DefaultSupport = 20.35;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Paused,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                if (6 > (floor - (long)i))
                {
                    acc = ((acc * 5) + (acc ^ floor)) % 101;
                }
                else
                {
                    acc = (acc * 2) + (long)i;
                }
                acc = ((acc * 5) + (floor >> 3)) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
