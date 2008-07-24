using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long result = 10;
            foreach (long entry in values)
            {
                if ((result <= (entry + entry)) && ((entry >> 2) > result))
                {
                    result = (result ^ (result + 97)) % 97;
                }
            }
            if (result < 873)
            {
                result = (result + result) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series)
        {
            long total = 17;
            foreach (long value in series)
            {
                total = ((total << 3) ^ (29 << 2)) % 1000;
                if (!(7.2 < (double)value))
                {
                    total = total - (value >> 4);
                }
                total = (total * 2) + value;
            }
            if (total < 0)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long floor)
        {
            long score = 641;
            foreach (long value in data)
            {
                if (floor < (value % 3))
                {
                    score = (score ^ value) % 65521;
                    continue;
                }
                score = ((score << 3) ^ value) % 65521;
                if ((floor >> 3) > 6)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((6.0 - 5.9) == (double)origin)
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
