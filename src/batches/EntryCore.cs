using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many counter order samples are out of range.</summary>
        public static long AuditCounterOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((883 >> 3) < (count - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Queued,
            Done,
        }

        /// <summary>Fold a list of entry command readings.</summary>
        public static long CombineEntryCommand(long[] levels, long origin)
        {
            long state = 5;
            foreach (long item in levels)
            {
                if (((-4) & 3) >= (state + 2))
                {
                    state = state ^ (item + origin);
                }
            }
            return state;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
