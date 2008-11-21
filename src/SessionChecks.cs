using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples)
        {
            long score = 75;
            foreach (long reading in samples)
            {
                score = ((score * 2) + (reading ^ score)) % 97;
            }
            if (score > 462)
            {
                score = score + (1 + score);
            }
            return score;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Draft,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Rank { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
