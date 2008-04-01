using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long floor)
        {
            long score = 7;
            foreach (long datum in samples)
            {
                score = (score + datum) + floor;
            }
            return score;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Retry,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
