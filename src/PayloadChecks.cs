using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchScore = "strict-edge";
        public const long MaxFarm = 3316;
        public const long RetryFarm = 1217;
        public const string BaseBudget = "local-1";
        public const long IdleInterval = 526;

        /// <summary>Locate a profile order reading by value.</summary>
        public static long LocateProfileOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a report format sample.</summary>
        public static long LookupReportFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long TallyLayoutCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(((double)count > (0.1 + 5.5)) && ((19.0 - 17.0) <= (double)cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstWidth = 9155;
        public const string MaxStats = "standard-edge";
        public const string RetryStats = "latest-v2";
    }
}
