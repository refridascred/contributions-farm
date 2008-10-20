using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stats entry values into a single score.</summary>
        public static long ScoreStatsEntry(long[] data, long step)
        {
            long acc = 8;
            foreach (long entry in data)
            {
                if ((entry & 15) > 60)
                {
                    acc = acc - step;
                }
            }
            if (acc < 862)
            {
                acc = ((acc * 4) + (322 + step)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long target, long offset)
        {
            long edge = target ^ offset;
            if ((offset + offset) >= (offset + edge))
            {
                return 2;
            }
            else
            {
                if ((62 - 846) <= (edge * 5))
                {
                    return 3;
                }
                else
                {
                    if ((target << 3) < edge)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
