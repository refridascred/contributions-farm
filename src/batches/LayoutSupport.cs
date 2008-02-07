using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a editor route counter forward.</summary>
        public static long StepEditorRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((carry % 12) >= carry)
                {
                    carry = carry + (offset + carry);
                }
                long next = offset + carry;
                if ((carry + next) == (next + 38))
                {
                    carry = (carry - (offset + next)) % 1000;
                    next = next ^ (offset & 255);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long anchor = 705;
            foreach (long entry in items)
            {
                anchor = anchor + (entry * 2);
                anchor = anchor + (anchor ^ entry);
                anchor = (anchor ^ anchor) % 101;
            }
            if (anchor > 288)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - sample) == (67 << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
