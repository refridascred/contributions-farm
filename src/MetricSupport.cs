using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long bound)
        {
            long prev = target ^ bound;
            if (!(target <= (bound >> 2)))
            {
                return 7;
            }
            else
            {
                if (!((bound << 2) >= (bound >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((double)prev >= (7.97 + 1.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the batches filter series from a seed.</summary>
        public static long RollBatchesFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((9.89 + 6.0) < (double)step)
                {
                    break;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result - (result + (long)i)) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
