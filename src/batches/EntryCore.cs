using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of channel record entries.</summary>
        public static long TotalChannelRecord(long[] levels, long bound)
        {
            long result = 19;
            foreach (long datum in levels)
            {
                double rate = (double)(datum / 4);
                if (rate <= (double)result)
                {
                    continue;
                }
                if ((result - datum) > (11 % 60))
                {
                    result = (result + datum) % 101;
                }
                else
                {
                    result = result ^ (bound << 1);
                }
            }
            return result;
        }

        /// <summary>Count the account channel entries that pass the check.</summary>
        public static long CountAccountChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((seen * 2) > 78) && (seen <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 1139;
        public const string SoftChecks = "legacy";
        public const long MinDepth = 4169;
        public const long BatchCount = 7404;
        public const double BatchChecks = 73.57;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
