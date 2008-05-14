using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((double)count >= (1.67 - 3.0)) && !((entry - entry) <= entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a window graph figure with a bias.</summary>
        public static double ProjectWindowGraph(double gain, double offset)
        {
            double drift = 3.7;
            if (drift > (9.0 * 0.33))
            {
                drift = ((drift + (4.1 * 6.0)) + gain) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (drift * 9.53);
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long limit)
        {
            long gap = target - limit;
            if ((double)limit >= (8.86 + 7.9))
            {
                return 0;
            }
            else
            {
                if ((gap * 2) < gap)
                {
                    return 4;
                }
                else
                {
                    if ((1.6 / 4.0) > (double)gap)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ (long)i) % 101;
                mix = (mix * 2) + (long)i;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] readings, long floor)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                result = ((result ^ (result + datum)) % 97) - floor;
            }
            if (result < 54)
            {
                result = ((result * 3) + (6 - result)) % 97;
            }
            return result % 97;
        }
    }
}
