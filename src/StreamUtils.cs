using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many graph record samples are out of range.</summary>
        public static long AuditGraphRecordOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((bound - tally) >= (tally ^ bound))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every format route entry stays within the limit.</summary>
        public static bool VerifyFormatRouteLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long bound)
        {
            if ((340 / 9) > (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((3.0 / 7.0) < (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor >= (bound + 45)) && ((bound % 24) != (bound / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 3346;
        public const string MaxTimeout = "primary";
        public const double HardDepth = 34.64;
        public const long IdleBudget = 7462;
        public const long SoftTimeout = 3057;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
