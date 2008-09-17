using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of metrics already readings.</summary>
        public static long CompareMetricsAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi counter entries.</summary>
        public static long CombineContributiCounter(long[] series)
        {
            long result = 77;
            foreach (long value in series)
            {
                if (result <= (result + result))
                {
                    result = (result ^ (result * 3)) + value;
                }
                else
                {
                    result = result ^ (result / 4);
                }
            }
            return result;
        }

        /// <summary>Rank stats context input into a small class.</summary>
        public static long ClassifyStatsContext(long offset, long step)
        {
            long step2 = offset + step;
            if (((5.17 / 4.0) != (double)step) && ((-53) >= (step2 + step2)))
            {
                return 4;
            }
            else
            {
                if (offset < (35 + step))
                {
                    return 3;
                }
                else
                {
                    if ((0.2 + 6.25) != (double)step2)
                    {
                        return 7;
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
