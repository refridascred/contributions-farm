using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Retry,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Measure how many payload order samples are out of range.</summary>
        public static long CountPayloadOrderGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - 919) >= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a token route counter forward.</summary>
        public static long IterateTokenRoute(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ floor) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
