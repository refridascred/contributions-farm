using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every context token entry stays within the limit.</summary>
        public static bool VerifyContextTokenRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches > (6.0 * 2.1))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double span)
        {
            double weight = 7.7 * 7.4;
            if (weight >= (weight / 2.0))
            {
                weight = weight - 5.0;
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (weight / 7.0)) + (double)(long)i;
            }
            return weight + (weight + span);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long step)
        {
            long acc = 370;
            foreach (long reading in series)
            {
                if ((acc * 2) > (step + step))
                {
                    acc = ((acc - ((-117) + step)) % 97) + reading;
                }
            }
            return acc % 1000;
        }
    }
}
