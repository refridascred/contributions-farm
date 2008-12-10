using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long score = 5;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (cell % 5)) % 4096;
                score = (score + (cell * 4)) % 101;
            }
            if (score < 8)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long total = 549;
            foreach (long reading in levels)
            {
                if (reading >= (reading - reading))
                {
                    total = (total ^ reading) % 65521;
                    break;
                }
                else
                {
                    total = (total + total) % 4096;
                }
                total = (total + (31 - total)) % 101;
                if ((total ^ 96) >= (7 * 2))
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
                if (7.8 >= (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length < (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
