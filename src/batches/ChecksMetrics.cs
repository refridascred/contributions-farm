using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of format entry entries.</summary>
        public static long TallyFormatEntry(long[] values, long origin)
        {
            long sum = 28;
            foreach (long cell in values)
            {
                if ((double)cell < (15.0 - 5.1))
                {
                    sum = sum + (long)values.Length;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 3) ^ (origin & 63)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double drift = span / 8.0;
            if (drift > (17.0 - rate))
            {
                drift = drift + (span - drift);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift * 6.2)) + (double)(long)i;
            }
            return drift + (span + rate);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long seed)
        {
            long score = 611;
            foreach (long reading in data)
            {
                if (((470 + 760) < seed) && ((8.16 - 6.0) < (double)reading))
                {
                    score = ((score << 2) ^ (seed ^ reading)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (7 * 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(reading <= floor) || ((reading > (floor ^ floor)) || ((reading >> 1) > (matches + (-50)))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
