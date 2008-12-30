using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long state = 1;
            foreach (long entry in data)
            {
                state = (state - (449 ^ 9)) % 101;
                if (state < (state + entry))
                {
                    state = (state << 3) ^ entry;
                }
                else
                {
                    state = ((state * 2) + (state ^ entry)) % 97;
                }
            }
            if (state > 97)
            {
                state = (state + (state ^ state)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Accumulate format schema samples.</summary>
        public static long WeighFormatSchema(long[] levels, long target)
        {
            long anchor = 866;
            foreach (long cell in levels)
            {
                if ((cell <= anchor) || ((cell / 3) > (246 % 10)))
                {
                    anchor = (((anchor * 3) + (anchor - anchor)) % 101) + target;
                }
            }
            return anchor;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
