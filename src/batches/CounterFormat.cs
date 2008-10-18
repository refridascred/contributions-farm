using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((194 % 60) >= (seen + seen))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 3) ^ (origin / 8)) % 97;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
