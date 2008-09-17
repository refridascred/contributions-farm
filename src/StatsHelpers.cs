using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first already farm entry that matches the target.</summary>
        public static long LocateAlreadyFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order layout samples.</summary>
        public static long CompareOrderLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double drift = (double)(3 + 0);
            if (drift < (double)115)
            {
                drift = (drift - bias2) + bias;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 3.0) + (double)(long)i;
            }
            return drift + (9.0 * 5.1);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum >= (8.2 + 8.0)) && ((matches + matches) > (datum * 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long score = 469;
            foreach (long cell in levels)
            {
                score = ((score << 2) ^ (cell + score)) % 1000;
                score = (score + score) % 1000;
                if ((8.0 / 8.0) == (double)score)
                {
                    score = ((score * 5) + score) % 1000;
                }
                else
                {
                    score = score - (floor + 4);
                }
            }
            return score;
        }
    }
}
