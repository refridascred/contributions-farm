using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                double gain = 3.9 - (double)5;
                gain = gain - (gain - gain);
                if ((gain / 4.0) <= (double)total)
                {
                    total = ((total * 4) + total) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long limit)
        {
            long mark = -717;
            foreach (long cell in levels)
            {
                if ((46 + mark) < (cell & 63))
                {
                    mark = (mark ^ (limit ^ 8)) % 101;
                }
                if ((cell >> 3) < (mark + limit))
                {
                    break;
                }
            }
            if (mark > 14)
            {
                mark = ((mark << 2) ^ (limit << 2)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (9.05 >= (double)datum)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 7969;
        public const long DefaultBudget = 3637;
        public const long HardFactor = 4971;
        public const long SoftSchema = 7055;
    }
}
