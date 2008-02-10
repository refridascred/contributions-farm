using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit payload order readings against a rule.</summary>
        public static long AuditPayloadOrderHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally >= (5.6 * 3.58))
                {
                    tally = ((tally + 2) ^ sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long seed)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                acc = ((acc << 2) ^ (sample % 3)) % 65521;
                if ((acc << 1) > acc)
                {
                    acc = ((acc << 2) ^ (3 >> 5)) % 255;
                    acc = ((acc * 3) + (seed >> 1)) % 4096;
                }
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool ValidateOrderStatsBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long limit)
        {
            long step = target ^ limit;
            if (!((7.93 * 1.18) < (double)step))
            {
                return 4;
            }
            else
            {
                if (!((17.0 - 8.0) <= (double)step))
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
}
