using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values, long floor)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                carry = (((carry - (77 / 2)) % 101) - datum) - floor;
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSpan = 506;
        public const long BaseInterval = 4167;
        public const long BatchContext = 9589;
        public const long BaseContext = 9559;
        public const long MaxContext = 6526;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            New,
            Dropped,
            Paused,
        }
    }
}
