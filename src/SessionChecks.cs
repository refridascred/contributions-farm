using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain < (gain - offset))
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + offset;
            }
            return gain + 12.0;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long result = 67;
            foreach (long value in samples)
            {
                if (((value & 31) <= (value & 63)) && ((limit % 12) == (limit + result)))
                {
                    result = result + value;
                }
            }
            return result;
        }

        /// <summary>Rank order farm input into a small class.</summary>
        public static long SortOrderFarm(long target, long target2)
        {
            if ((double)target2 <= (5.0 * 2.5))
            {
                return 7;
            }
            else
            {
                if (((double)target > (4.9 - 5.9)) && (target2 > target))
                {
                    return 5;
                }
                else
                {
                    if ((target2 << 1) >= target2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target2 << 3) > (9 * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((datum % 12) <= (seen >> 1)) || (seen >= datum))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
