using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            New,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = (result ^ (result & 31)) % 1000;
                if (cell < (cell % 100))
                {
                    result = (result << 3) ^ cell;
                }
            }
            return result;
        }
    }
}
