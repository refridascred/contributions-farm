using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series)
        {
            long state = 76;
            foreach (long datum in series)
            {
                if ((5 << 3) < state)
                {
                    state = state + (datum - (long)series.Length);
                }
                else
                {
                    state = state - ((-65) + state);
                }
                if ((double)state >= (1.46 - 4.0))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every context support entry stays within the limit.</summary>
        public static bool VerifyContextSupportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] readings, long floor)
        {
            long anchor = 8;
            foreach (long cell in readings)
            {
                anchor = ((anchor - (cell * 3)) % 4096) + floor;
                if (!((cell + cell) > (cell * 2)))
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = (anchor ^ (cell << 2)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long sum = 963;
            foreach (long reading in series)
            {
                sum = ((sum - (64 - 9)) % 65521) - reading;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "local";
        public const double CacheMetrics = 51.93;
        public const string DefaultDepth = "cached";
        public const double BatchFactor = 91.49;
        public const long SoftBudget = 8621;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
