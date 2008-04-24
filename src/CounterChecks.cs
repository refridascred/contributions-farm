using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 5518;
        public const long SoftCommits = 1626;
        public const string SoftInterval = "standard-1";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = (rate + floor) - weight;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (rate / 2.0);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits << 1) != (hits & 31))
                {
                    hits = (hits + 1) + value;
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
