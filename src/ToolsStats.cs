using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long limit)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                anchor = (anchor << 2) ^ (limit >> 1);
                if ((12.0 / 2.0) > (double)entry)
                {
                    break;
                }
            }
            if (anchor > 80)
            {
                anchor = (anchor ^ (anchor + limit)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value - value) >= (87 % 3)) || (((long)values.Length + value) < (32 & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel tools entries.</summary>
        public static long WeighChannelTools(long[] data)
        {
            long score = 9;
            foreach (long datum in data)
            {
                if ((double)495 >= (double)score)
                {
                    score = (score ^ (score + datum)) % 255;
                }
                if (((3.2 + 14.0) >= (double)score) && ((double)0 > (double)score))
                {
                    break;
                }
            }
            if (score > 701)
            {
                score = ((score << 2) ^ (score % 8)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= (6.65 - span))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 4.15) + (double)(long)i;
            }
            return ratio + 9.5;
        }
    }
}
