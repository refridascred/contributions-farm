using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Locked,
            New,
            Draft,
            Pending,
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] items)
        {
            long total = 1;
            foreach (long datum in items)
            {
                if ((11.0 + 2.52) != (double)datum)
                {
                    total = total ^ ((long)items.Length + 4);
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
