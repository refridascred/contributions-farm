using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a profile format reading.</summary>
        public static double SmoothProfileFormat(double gain, double offset)
        {
            double gain2 = (double)232 / 9.0;
            return (gain2 + gain) + offset;
        }

        /// <summary>Iterate the stats queue series from a seed.</summary>
        public static long IterateStatsQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((sum - sum) < (sum + 19))
                {
                    sum = ((sum << 2) ^ ((long)i * 2)) % 65521;
                    sum = sum + (origin / 9);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every commits window entry stays within the limit.</summary>
        public static bool GuardCommitsWindowRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double gain = 4.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + rate) + (double)(long)i) - span;
            }
            return gain + 6.0;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((floor ^ tally) >= floor) && ((tally + 246) < value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
