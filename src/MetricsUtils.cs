using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long score = 7;
            foreach (long cell in series)
            {
                if (7 < (5 - score))
                {
                    score = ((score * 2) + (cell / 8)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (cell ^ cell)) % 65521;
                }
                if ((cell * 5) <= score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long seed, long origin)
        {
            if ((origin / 3) >= (origin & 15))
            {
                return 2;
            }
            else
            {
                if (!((seed >> 2) != (origin - seed)))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) <= (seed + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + origin) < (60 + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Stale,
            Dropped,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
