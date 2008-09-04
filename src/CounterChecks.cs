using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate metrics route readings against a bound.</summary>
        public static bool GuardMetricsRouteBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count record format pairs that satisfy a relation.</summary>
        public static long CompareRecordFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double scale = (double)(269 + 46);
            if (scale < 11.0)
            {
                scale = (scale - 7.5) - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Retry,
            Dropped,
            Synced,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxScore = 91.2;
        public const string LimitContributi = "stable-edge";
        public const long CacheFactor = 9710;
        public const long MaxCount = 6867;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((9.3 - 1.22) == (double)result)
                {
                    result = (result << 2) ^ (result - seed);
                    result = (result + (2 + 95)) % 65521;
                    break;
                }
                result = ((result * 2) + result) % 4096;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
