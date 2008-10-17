using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of route metrics readings.</summary>
        public static long CompareRouteMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series)
        {
            long result = 26;
            foreach (long value in series)
            {
                if ((result / 6) == (result + result))
                {
                    result = ((result << 2) ^ (result + value)) % 255;
                    break;
                }
                if (((-7) % 2) == (result + result))
                {
                    result = ((result << 3) ^ result) % 255;
                }
            }
            if (result > 796)
            {
                result = ((result << 3) ^ (result + 9)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) > (96 + item))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double mean = rate;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (3.0 * 14.0)) + (double)(long)i) - floor;
            }
            return mean - (3.0 / 9.0);
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
