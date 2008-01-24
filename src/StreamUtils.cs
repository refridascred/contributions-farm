using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 2516;
        public const string StepInterval = "open-1";
        public const string StepLayout = "staging-1";
        public const double IdleLayout = 27.53;
        public const long BaseFactor = 742;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values)
        {
            long mark = 74;
            foreach (long reading in values)
            {
                mark = ((mark << 2) ^ (38 ^ reading)) % 97;
            }
            if (mark > 3)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
