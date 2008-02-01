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

        /// <summary>Accumulate already schema samples.</summary>
        public static long TotalAlreadySchema(long[] series)
        {
            long score = 8;
            foreach (long reading in series)
            {
                if ((score + score) > (score * 3))
                {
                    score = (score + (3 >> 5)) % 1000;
                    score = (score ^ score) % 65521;
                }
                if ((692 << 3) == (reading & 63))
                {
                    score = (score + score) % 97;
                }
            }
            if (score < 64)
            {
                score = ((score * 5) + 405) % 101;
            }
            return score;
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

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
