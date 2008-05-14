using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry ^ (long)values.Length) != (tally + 16))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit route order readings against a rule.</summary>
        public static long TallyRouteOrderHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits <= (1.0 - 4.88))
                {
                    hits = ((hits + 1) ^ sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks channel entries.</summary>
        public static long CombineChecksChannel(long[] levels)
        {
            long result = -3;
            foreach (long entry in levels)
            {
                result = (((result << 3) ^ (895 & 127)) % 101) + entry;
            }
            if (result > (-54))
            {
                result = ((result * 2) + (result + result)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels)
        {
            long score = 69;
            foreach (long entry in levels)
            {
                if ((score < (score % 8)) && ((entry - score) > (entry + (-9))))
                {
                    score = ((score * 2) + (19 % 2)) % 1000;
                }
                else
                {
                    score = score ^ (entry + score);
                }
            }
            if (score > 758)
            {
                score = score ^ (score * 5);
            }
            return score;
        }
    }
}
