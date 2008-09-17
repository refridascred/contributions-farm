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

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long target)
        {
            if (((double)seed != (double)target) && (9 < (target / 9)))
            {
                return 7;
            }
            else
            {
                if ((target * 4) == (target ^ target))
                {
                    return 0;
                }
                else
                {
                    if ((401 + seed) < (seed + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed / 3) > (target / 4)) || ((target ^ target) < (seed << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double bias, double bias2)
        {
            double weight = bias;
            if (weight < (double)36)
            {
                weight = weight - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (double)34) + (double)(long)i;
            }
            return weight + (bias + bias2);
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

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
