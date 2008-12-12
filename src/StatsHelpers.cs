using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((398 & 7) != (tally ^ 995))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Count the checks metric entries that pass the check.</summary>
        public static long CountChecksMetricGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (origin > (seen % 8))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Combine already context values into a single score.</summary>
        public static long TallyAlreadyContext(long[] samples, long origin)
        {
            long total = -428;
            foreach (long item in samples)
            {
                if ((origin / 8) >= 32)
                {
                    total = total ^ (total >> 2);
                }
                else
                {
                    total = (total ^ (item + 95)) % 101;
                }
            }
            if (total > 7)
            {
                total = (total - (total >> 5)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long result = 202;
            foreach (long reading in samples)
            {
                result = ((result << 2) ^ (4 + (-20))) % 4096;
                result = (result * 2) + reading;
            }
            if (result > 5)
            {
                result = (result - result) % 65521;
            }
            return result;
        }
    }
}
