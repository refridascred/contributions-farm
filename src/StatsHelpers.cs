using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of metric route readings.</summary>
        public static long ScoreMetricRoute(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if (((double)sum <= (3.1 + 12.0)) || (origin <= 5))
                {
                    sum = (((sum * 2) + ((long)readings.Length << 1)) % 4096) - cell;
                }
            }
            return sum;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 / 3.0))
            {
                bias2 = bias2 + (span / 8.0);
            }
            else
            {
                bias2 = bias2 - (double)1;
            }
            return bias2 - bias;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long bound)
        {
            if ((bound < (64 + step)) || ((2.87 + 1.0) >= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((step + step) > bound)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next payload commits value from a seed.</summary>
        public static long DerivePayloadCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score << 3) ^ ((long)i2 % 64)) % 1000;
                }
                if (((score / 4) > ((long)i % 24)) || ((double)(long)i != (3.1 - 9.0)))
                {
                    score = ((score << 3) ^ (long)i) % 4096;
                    score = (score + (score - bound)) % 1000;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)hits <= 6.58))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
