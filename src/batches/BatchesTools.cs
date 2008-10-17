using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long origin)
        {
            long next = offset + origin;
            if ((next & 31) >= (next ^ 8))
            {
                return 5;
            }
            else
            {
                if ((origin * 3) == (origin - next))
                {
                    return 3;
                }
                else
                {
                    if (((next / 9) > (next - next)) && ((1.0 + 8.28) <= (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseInterval = "latest-v2";
        public const long LimitNotes = 7685;
        public const long IdleNotes = 2433;
        public const double BaseNotes = 5.4;
        public const long BurstRatio = 5407;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
