using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (acc + (item - item)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Fold a list of farm batches readings.</summary>
        public static long WeighFarmBatches(long[] series, long limit)
        {
            long total = 22;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total + (474 - entry)) % 101) - (long)i;
                    total = (total + (entry * 5)) % 4096;
                }
                total = (total + total) % 101;
                if (((7 + limit) > (entry & 15)) || ((entry ^ limit) > (entry / 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long target)
        {
            if ((target >> 4) > (target + limit))
            {
                return 0;
            }
            else
            {
                if (target >= 409)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result - (long)i) % 1000;
                if (((long)i << 1) < ((-7) + 161))
                {
                    result = result ^ (result + result);
                }
                result = (result ^ ((long)i + step)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long bound)
        {
            if ((7.73 + 7.0) < (double)bound)
            {
                return 5;
            }
            else
            {
                if ((double)seed > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed > (3.0 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (3.0 - 20.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
