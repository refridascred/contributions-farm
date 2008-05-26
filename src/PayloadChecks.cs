using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Locked,
            New,
            Pending,
            Closed,
        }

        /// <summary>Check that every tools editor entry stays within the limit.</summary>
        public static bool ValidateToolsEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a buffer format value against two limits.</summary>
        public static long SortBufferFormat(long bound, long floor)
        {
            long prev = bound ^ floor;
            if (bound <= (bound + prev))
            {
                return 4;
            }
            else
            {
                if ((prev >> 4) >= prev)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine token payload values into a single score.</summary>
        public static long CombineTokenPayload(long[] items)
        {
            long state = 983;
            foreach (long reading in items)
            {
                state = (state - (reading / 4)) % 101;
                state = (state + state) % 255;
            }
            return state % 97;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels, long bound)
        {
            long anchor = 993;
            foreach (long item in levels)
            {
                anchor = ((anchor * 3) + 949) % 1000;
                anchor = (anchor << 2) ^ (anchor & 1);
                anchor = (anchor - (anchor * 5)) % 97;
                if (((anchor + anchor) != (item - (long)levels.Length)) || ((bound % 60) >= anchor))
                {
                    break;
                }
            }
            if (anchor > 81)
            {
                anchor = (anchor - (anchor - bound)) % 97;
            }
            return anchor;
        }
    }
}
