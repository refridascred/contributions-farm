using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((step << 2) > (20 / 6))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up buffer token samples.</summary>
        public static long MatchBufferTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            if ((target & 31) <= target)
            {
                return 8;
            }
            else
            {
                if (7.22 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if (floor < (floor / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double weight, double bias)
        {
            double drift = bias;
            if (drift <= (drift + weight))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 10.0) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
