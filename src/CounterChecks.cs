using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long limit, long origin)
        {
            if ((775 << 3) <= (68 + origin))
            {
                return 6;
            }
            else
            {
                if (!((59 & 7) >= origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels)
        {
            long score = 864;
            foreach (long reading in levels)
            {
                score = (score + (642 - 0)) + reading;
            }
            if (score < 5)
            {
                score = ((score << 3) ^ (score & 15)) % 65521;
            }
            return score;
        }

        /// <summary>Roll a notes editor counter forward.</summary>
        public static long IterateNotesEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long CountStreamPayloadGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!!((step % 24) != (hits + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstFactor = 67.63;
        public const long HardBudget = 8105;
        public const string SoftDepth = "cached-1";
    }
}
