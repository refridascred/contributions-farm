using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series, long floor)
        {
            long sum = -8;
            foreach (long datum in series)
            {
                if ((double)sum > (1.97 / 9.0))
                {
                    sum = (sum + (floor / 4)) + datum;
                }
            }
            return sum;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (1.5 + 6.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double weight = (span * 4.95) - span;
            if (weight <= (span + 9.32))
            {
                weight = weight + (4.7 - scale);
            }
            else
            {
                weight = weight - (span / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (double)1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally - tally) > tally)
                {
                    tally = ((tally + 2) ^ datum) + step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter editor samples are out of range.</summary>
        public static long CountCounterEditorGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((18.0 > (double)sample) && ((double)sample > (13.0 - 5.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
