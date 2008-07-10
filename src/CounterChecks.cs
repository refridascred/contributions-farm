using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = (result - (origin - result)) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + (long)i) == (long)i)
                {
                    mark = ((mark << 2) ^ ((long)i % 10)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long DeriveBatchesOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((total * 4) >= offset)
                {
                    total = (total << 2) ^ (offset + (long)i);
                }
                total = total ^ (total - total);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = mark + ((long)i2 & 63);
                }
                if (!((offset <= (72 - mark)) && ((offset % 24) == (offset - (long)i))))
                {
                    mark = ((mark * 5) + offset) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((sum / 8) < ((-155) + sum))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit route queue readings against a rule.</summary>
        public static long CountRouteQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits - hits) > (hits << 2))
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
