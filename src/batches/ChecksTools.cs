using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long origin, long step)
        {
            if (((origin + step) <= (origin - origin)) || ((double)step <= (6.0 / 4.0)))
            {
                return 4;
            }
            else
            {
                if ((origin % 10) <= step)
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 4) == (step & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + step) >= (origin - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
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
