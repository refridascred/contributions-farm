using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double scale, double offset)
        {
            double scale2 = (offset / 3.0) + scale;
            if (scale2 < (double)(-903))
            {
                scale2 = scale2 - scale;
            }
            return scale2 + (scale2 + scale2);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 519;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (total + 2)) % 1000;
                total = (total + (item + total)) % 101;
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long seed, long limit)
        {
            long step = seed - limit;
            if (((8 + limit) <= seed) && ((step - (-731)) != (seed / 7)))
            {
                return 5;
            }
            else
            {
                if (((seed + limit) == (235 << 1)) && ((limit ^ step) != (limit / 5)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (2.88 - 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed < (seed ^ limit)) && (step > (9 % 60)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
