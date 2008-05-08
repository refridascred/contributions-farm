using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "local-1";
        public const long CacheBudget = 6994;
        public const long WindowReport = 2689;
        public const long BaseReport = 2250;
        public const long BaseFactor = 561;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "legacy";
        public const long BurstFilter = 9767;
        public const long MinFilter = 3829;
    }
}
