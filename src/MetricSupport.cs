using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long offset2)
        {
            long bound = offset - offset2;
            if ((double)bound <= (4.43 - 3.4))
            {
                return 1;
            }
            else
            {
                if (offset < (offset >> 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = score - (score >> 3);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
