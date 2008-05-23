using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 9506;
        public const long SoftLayout = 7690;
        public const long IdleBudget = 8572;

        /// <summary>Audit stats token readings against a rule.</summary>
        public static long MeasureStatsTokenHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen > (78 + seen)) || ((seen % 7) != (1 << 2))) || (cell > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((matches - matches) <= (reading * 3)))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long bound)
        {
            long prev = target + bound;
            if ((double)879 >= (double)bound)
            {
                return 5;
            }
            else
            {
                if (target >= (prev * 2))
                {
                    return 3;
                }
                else
                {
                    if (target <= (prev + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
