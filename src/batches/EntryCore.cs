using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Active,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Locate a command record reading by value.</summary>
        public static long SeekCommandRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already notes value from a seed.</summary>
        public static long SeriesAlreadyNotes(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (long)i) % 101;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every channel cluster entry stays within the limit.</summary>
        public static bool ValidateChannelClusterLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowSize = "latest";
        public const double BurstRatio = 98.03;
        public const string StepToken = "legacy-1";
    }
}
