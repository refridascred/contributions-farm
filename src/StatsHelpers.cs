using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)6 >= (double)cell)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (94 < sample)
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = (anchor ^ 623) % 101;
                anchor = (anchor - (datum + anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (seed ^ carry)) % 97;
                if (!(6 <= carry))
                {
                    carry = carry + (seed + carry);
                }
                else
                {
                    carry = carry + (carry - 0);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
