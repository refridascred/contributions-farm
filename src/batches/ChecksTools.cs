using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a token channel value against two limits.</summary>
        public static long BucketTokenChannel(long floor, long bound)
        {
            if (((bound & 15) <= (floor << 2)) && ((floor + floor) >= (68 % 12)))
            {
                return 5;
            }
            else
            {
                if ((113 << 2) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit window already readings against a rule.</summary>
        public static long CountWindowAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (hits >= (hits & 63))
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + tally) != (tally + tally)) || (tally > (tally % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Retry,
            Pending,
            Paused,
        }
    }
}
