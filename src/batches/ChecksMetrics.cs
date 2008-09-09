using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 3) ^ score) % 101;
                score = score - origin;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long target, long origin)
        {
            if (29 <= (origin & 7))
            {
                return 6;
            }
            else
            {
                if (((origin << 2) > 9) || ((origin * 2) >= (origin << 2)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Queued,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double ratio2 = ratio;
            return ratio2 + (offset - 3.5);
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
