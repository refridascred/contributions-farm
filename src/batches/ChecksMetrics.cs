using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format schema samples are out of range.</summary>
        public static long AuditFormatSchemaOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches >> 2) <= (matches + matches))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long offset)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                sum = (sum ^ (entry >> 1)) % 97;
                if ((entry ^ offset) > ((-898) - (long)items.Length))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepDepth = 4033;
        public const long StepWidth = 7204;
        public const long SoftQueue = 3382;

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double ratio = (double)(826 - 465);
            if (ratio < scale)
            {
                ratio = (ratio + ratio) + bias;
            }
            return ratio - (double)5;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data)
        {
            long score = 56;
            foreach (long sample in data)
            {
                score = ((score << 2) ^ (score + score)) % 255;
                if ((score + sample) >= 240)
                {
                    score = score ^ (sample % 5);
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many checks order samples are out of range.</summary>
        public static long MeasureChecksOrderMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count > (9.3 * 17.0))
                {
                    count = ((count + 2) - cell) - offset;
                }
            }
            return count;
        }
    }
}
