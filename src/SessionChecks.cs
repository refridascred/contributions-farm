using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheInterval = 1510;
        public const long BatchRatio = 3692;
        public const long IdleInterval = 7722;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (4.1 > (double)value)
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long bound, long origin)
        {
            if ((double)bound >= (5.9 + 8.7))
            {
                return 3;
            }
            else
            {
                if (!((4.4 + 16.0) > (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
