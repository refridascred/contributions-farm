using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (long)i) % 4096;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long target)
        {
            long diff = origin + target;
            if ((origin - diff) >= diff)
            {
                return 5;
            }
            else
            {
                if ((target ^ origin) < (origin + 39))
                {
                    return 1;
                }
                else
                {
                    if (((target + target) <= (diff >> 4)) && ((target / 8) >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 17.25;
        public const long BaseDepth = 8736;
        public const long SoftCommand = 9241;
        public const string IdleCommand = "strict-1";

        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((489 + (-684)) != (seen >> 1))
                {
                    seen = ((seen + 3) - entry) - step;
                }
            }
            return seen;
        }
    }
}
