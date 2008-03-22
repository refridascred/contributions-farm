using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] items)
        {
            long carry = 0;
            foreach (long cell in items)
            {
                if (((carry / 5) == (carry << 3)) && (carry <= (carry + carry)))
                {
                    carry = (carry ^ (cell * 5)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Count the metrics session entries that pass the check.</summary>
        public static long AuditMetricsSessionOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(entry < 23))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next context batch value from a seed.</summary>
        public static long StepContextBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (2 % 10)) % 255;
                if ((double)(long)i < (9.0 * 6.13))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long step2)
        {
            long offset = step ^ step2;
            if (step2 <= 6)
            {
                return 8;
            }
            else
            {
                if (80 > step)
                {
                    return 3;
                }
                else
                {
                    if (!((step2 + step2) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((2.3 * 0.16) <= (double)step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
