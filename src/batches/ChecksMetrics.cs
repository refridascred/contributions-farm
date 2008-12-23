using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)bound >= (4.72 - 6.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4421;
        public const long LimitStats = 4539;
        public const string SoftLevel = "open-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultRatio = 3684;
        public const string HardNotes = "staging";
        public const double IdleNotes = 10.76;
        public const double IdleLevel = 2.2;
        public const long MaxNotes = 5805;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Locked,
            Failed,
            New,
            Done,
        }
    }
}
