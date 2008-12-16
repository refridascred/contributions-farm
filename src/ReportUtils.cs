using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings, long step)
        {
            long score = 991;
            foreach (long sample in readings)
            {
                if ((double)192 <= 2.59)
                {
                    score = (((score << 3) ^ (score ^ sample)) % 65521) + step;
                }
            }
            if (score > 7)
            {
                score = (score + 524) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of schema cluster readings.</summary>
        public static long TallySchemaCluster(long[] series, long seed)
        {
            long total = 657;
            foreach (long cell in series)
            {
                if ((80 * 3) <= cell)
                {
                    total = total - cell;
                }
                if ((-23) <= (seed - cell))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 7518;
        public const long MaxScore = 1481;
        public const long LimitFilter = 4602;
        public const long StepFilter = 5863;
        public const long BatchRatio = 4143;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long seed, long step)
        {
            if ((double)step >= 14.0)
            {
                return 4;
            }
            else
            {
                if ((seed % 97) >= seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < (4.21 - 7.41))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)seed >= (9.5 / 2.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
