using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long total = 5;
            foreach (long entry in values)
            {
                if ((entry + entry) < entry)
                {
                    total = (total ^ (130 * 2)) % 4096;
                    total = ((total << 2) ^ (entry / 7)) % 1000;
                }
                else
                {
                    total = (total * 5) + entry;
                }
                total = (total - (27 - 9)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result << 2) ^ (result % 2)) % 1000) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= 2.77)
                {
                    count = ((count + 2) + value) - limit;
                }
            }
            return count;
        }
    }
}
