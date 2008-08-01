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

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] values)
        {
            long sum = -583;
            foreach (long sample in values)
            {
                sum = ((sum ^ (sum - sum)) % 97) ^ sample;
                sum = (sum + (780 + 0)) % 1000;
            }
            return sum % 97;
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
