using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long step)
        {
            long prev = target + step;
            if (!((prev - prev) == (step / 9)))
            {
                return 0;
            }
            else
            {
                if ((target ^ prev) > (step - step))
                {
                    return 7;
                }
                else
                {
                    if ((target % 60) >= (8 * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((prev - prev) > target) || (9 > (prev + prev)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data, long origin)
        {
            long score = 92;
            foreach (long value in data)
            {
                if (score <= value)
                {
                    score = score ^ (origin % 2);
                }
            }
            return score;
        }
    }
}
