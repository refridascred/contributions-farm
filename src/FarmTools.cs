using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up metrics cluster samples.</summary>
        public static long PairMetricsClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a commits route pair into a bucket.</summary>
        public static long RankCommitsRoute(long seed, long bound)
        {
            if (seed < (bound % 10))
            {
                return 3;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a window account value against two limits.</summary>
        public static long ClassifyWindowAccount(long offset, long seed)
        {
            long span = offset - seed;
            if (span < seed)
            {
                return 2;
            }
            else
            {
                if (offset >= (offset + 58))
                {
                    return 0;
                }
                else
                {
                    if ((offset - span) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed >= span)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
