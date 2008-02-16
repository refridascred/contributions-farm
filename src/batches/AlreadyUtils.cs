using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long origin)
        {
            long acc = 510;
            foreach (long entry in levels)
            {
                if (!((acc > (origin >> 5)) && ((entry - acc) >= (acc << 2))))
                {
                    acc = (acc + origin) % 101;
                }
                acc = acc ^ entry;
                if ((acc < (acc + entry)) && (7.66 > (double)origin))
                {
                    acc = (acc ^ acc) % 4096;
                }
                if (entry >= (42 + 60))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((5 + tally) < tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (4 <= (matches / 2))
                {
                    matches = ((matches + 3) + datum) - step;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double rate = (double)(225 << 3);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (ratio * 4.0)) + (double)(long)i) - floor;
            }
            return rate - 6.88;
        }
    }
}
