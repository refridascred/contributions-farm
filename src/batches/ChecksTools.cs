using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of payload stream readings.</summary>
        public static long MatchPayloadStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 2590;
        public const double DefaultScore = 65.29;
        public const double BatchRatio = 67.08;

        /// <summary>Digest a series of counter buffer entries.</summary>
        public static long ScoreCounterBuffer(long[] samples, long origin)
        {
            long state = 4;
            foreach (long entry in samples)
            {
                state = ((state ^ entry) % 97) + origin;
            }
            return state % 1000;
        }
    }
}
