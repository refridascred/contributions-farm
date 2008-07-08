using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 5453;
        public const long BurstTimeout = 3220;
        public const long RetryFactor = 4272;
        public const double StepNotes = 98.95;
        public const long DefaultScore = 9601;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session support readings.</summary>
        public static long TallySessionSupport(long[] levels)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                mix = ((mix - (mix << 2)) % 97) + item;
                if ((mix - 384) <= mix)
                {
                    mix = (mix ^ (mix / 6)) % 65521;
                }
            }
            return mix;
        }
    }
}
