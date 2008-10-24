using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample << 2) == (floor >> 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 3) ^ (38 << 3);
                state = (state ^ floor) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Retry,
            Queued,
        }
    }
}
