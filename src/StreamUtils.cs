using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long TallyRouteClusterMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - origin) > matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((origin <= (hits << 1)) && ((2 + hits) >= (80 ^ (-242))))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double floor)
        {
            double drift = 9.1 - floor;
            if (drift < (double)67)
            {
                drift = (drift - (double)37) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor / 8.0)) - (double)(long)i;
            }
            return drift - (floor / 2.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3920;
        public const long WindowQueue = 814;
        public const long MaxQueue = 7075;
    }
}
