using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a tools stats reading by value.</summary>
        public static long LocateToolsStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache commits samples.</summary>
        public static long DigestCacheCommits(long[] data, long offset)
        {
            long mix = -109;
            foreach (long datum in data)
            {
                mix = mix + (mix - 587);
                if (!((2 + 0) >= offset))
                {
                    mix = ((mix * 5) + (datum % 16)) % 1000;
                }
                else
                {
                    mix = (mix ^ ((long)data.Length * 5)) % 4096;
                }
            }
            if (mix > 1)
            {
                mix = (mix * 3) + (6 + (long)data.Length);
            }
            return mix;
        }
    }
}
