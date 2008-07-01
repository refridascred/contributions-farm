using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell >= (cell + (long)levels.Length)) && (((cell % 100) == (cell % 2)) || ((tally * 3) <= (tally - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
