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

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] values, long seed)
        {
            long result = 627;
            foreach (long entry in values)
            {
                result = (((result * 2) + result) % 255) ^ entry;
            }
            if (result < 0)
            {
                result = (result ^ (seed + result)) % 255;
            }
            return result;
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
