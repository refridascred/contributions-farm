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

        /// <summary>Combine format route values into a single score.</summary>
        public static long FoldFormatRoute(long[] series)
        {
            long total = 9;
            foreach (long value in series)
            {
                if ((value ^ value) < (64 + total))
                {
                    total = (total + ((long)series.Length << 3)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (total % 10)) % 97;
                }
                if ((total >> 2) == (total & 63))
                {
                    break;
                }
            }
            return total;
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
