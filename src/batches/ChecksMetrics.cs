using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Locked,
            Failed,
        }

        /// <summary>Locate a account notes reading by value.</summary>
        public static long SeekAccountNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 3672;
        public const long IdleLayout = 9514;
        public const long MinLayout = 8489;
        public const double RetryLayout = 61.98;

        /// <summary>Count the record entry entries that pass the check.</summary>
        public static long MeasureRecordEntryHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((3.5 - 10.0) <= (double)seed)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}
