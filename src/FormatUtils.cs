using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                if ((double)value > (5.78 - 15.0))
                {
                    anchor = anchor + value;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate metric stream samples.</summary>
        public static long CombineMetricStream(long[] levels, long target)
        {
            long score = 490;
            foreach (long value in levels)
            {
                score = (score ^ (66 - 0)) % 65521;
                score = score ^ score;
                if ((double)value < (5.5 * 7.0))
                {
                    score = (score * 3) + (score + score);
                }
                else
                {
                    score = (score << 2) ^ (score - score);
                }
            }
            if (score < 99)
            {
                score = ((score << 2) ^ target) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - tally) <= tally)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((0.9 / 4.0) > (double)item) && ((double)hits > (2.8 + 6.0))) && ((hits > (floor ^ 66)) || ((1.4 / 5.0) <= 8.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((207 / 2) >= matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
