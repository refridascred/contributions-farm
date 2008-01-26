using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record context counter forward.</summary>
        public static long IterateRecordContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((83 & 7) <= ((long)i & 127))
                {
                    continue;
                }
                else
                {
                    total = ((total * 3) + (origin / 5)) % 65521;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series)
        {
            long score = 27;
            foreach (long cell in series)
            {
                score = ((score * 4) + (score + score)) ^ cell;
                score = ((score * 4) + score) % 101;
            }
            if (score > (-8))
            {
                score = (score ^ (score % 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - seen) < cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double mean = (ratio / 5.0) / 9.0;
            if (mean < (18.0 - ratio))
            {
                mean = mean + (offset - ratio);
            }
            return mean + offset;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double scale, double offset)
        {
            double scale2 = scale - scale;
            if (scale2 >= (double)7)
            {
                scale2 = scale2 + (double)67;
            }
            else
            {
                scale2 = scale2 + (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + offset) + (double)(long)i;
            }
            return scale2 + (double)57;
        }
    }
}
