using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a record batches value against two limits.</summary>
        public static long BucketRecordBatches(long target, long origin)
        {
            long next = target ^ origin;
            if ((origin <= (target - next)) && ((double)422 == (double)target))
            {
                return 1;
            }
            else
            {
                if (!((next * 2) != (target - origin)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long target2)
        {
            long edge = target - target2;
            if ((target2 ^ edge) != (target + 967))
            {
                return 4;
            }
            else
            {
                if (((target2 << 3) > (target2 ^ edge)) || ((9.54 + 6.1) >= (double)edge))
                {
                    return 1;
                }
                else
                {
                    if ((target2 <= target) && ((edge + target2) > target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.1 * 17.0) > 16.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double mean = span;
            if (mean < scale)
            {
                mean = mean + (mean * 8.17);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span - 12.0)) + (double)(long)i;
            }
            return mean + (span - 17.0);
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double ratio, double bias)
        {
            double drift = (double)((-870) + 38);
            if (drift >= (double)669)
            {
                drift = (drift - (double)(-35)) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (2.1 + 3.0)) + (double)(long)i;
            }
            return drift + (bias + bias);
        }
    }
}
