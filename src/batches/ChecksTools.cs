using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleFactor = 83.05;
        public const string MinWidth = "latest-1";
        public const long MinCount = 986;

        /// <summary>Validate counter command readings against a bound.</summary>
        public static bool GuardCounterCommandBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit filter window readings against a rule.</summary>
        public static long MeasureFilterWindowHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen << 3) < (seen & 127)) || (((6 - seen) < sample) || (((-40) * 4) > seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
