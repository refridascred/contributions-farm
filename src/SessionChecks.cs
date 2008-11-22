using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long result = 303;
            foreach (long sample in items)
            {
                if (!((sample + result) < (sample * 5)))
                {
                    result = result + (result / 4);
                }
                else
                {
                    result = ((result << 2) ^ (sample - result)) % 1000;
                }
            }
            if (result > 0)
            {
                result = (result - (result & 1)) % 101;
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long acc = 49;
            foreach (long entry in readings)
            {
                if ((acc + 25) > acc)
                {
                    acc = acc ^ entry;
                }
                if ((2.42 - 18.0) < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Failed,
            Pending,
            Done,
            Stale,
        }
    }
}
