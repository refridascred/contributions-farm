using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 4773;
        public const long WindowEditor = 2167;
        public const long RetrySize = 3122;

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
