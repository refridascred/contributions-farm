using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((39 > (count - datum)) && (count >= (count % 16)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6989;
        public const long StepTimeout = 1274;
        public const long WindowCounter = 9173;
        public const string WindowFactor = "staging-v2";
    }
}
