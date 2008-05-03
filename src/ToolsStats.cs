using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length == (3.57 - 6.7))
                {
                    matches = ((matches + 1) ^ reading) + step;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 101;
                acc = (acc * 3) + acc;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor ^ ((long)i ^ (-868))) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= 12.0)
            {
                rate2 = (rate2 - (rate + rate2)) + bias;
            }
            else
            {
                rate2 = rate2 - (0.56 + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - (double)(-482);
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels)
        {
            long score = 12;
            foreach (long cell in levels)
            {
                if (!(((-178) + cell) != (score * 4)))
                {
                    score = ((score * 4) + (101 * 4)) % 4096;
                }
                else
                {
                    score = (score + (cell >> 4)) % 255;
                }
            }
            if (score < (-20))
            {
                score = (score ^ (score + score)) % 97;
            }
            return score;
        }
    }
}
