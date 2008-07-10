using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every record notes entry stays within the limit.</summary>
        public static bool GuardRecordNotesRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading >= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double weight = (double)23 / 2.0;
            return (weight - scale) + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitScore = 34.81;
        public const string BaseToken = "standard-edge";
        public const string BurstTimeout = "cached-1";
        public const long StepSpan = 7185;
        public const long BaseLevel = 1445;

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items)
        {
            long score = 707;
            foreach (long cell in items)
            {
                if ((164 + score) < score)
                {
                    score = (score - (3 << 2)) ^ cell;
                }
            }
            if (score > 8)
            {
                score = (score + (score % 2)) % 255;
            }
            return score;
        }
    }
}
