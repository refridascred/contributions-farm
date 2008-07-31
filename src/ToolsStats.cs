using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Closed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Done,
            Idle,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples)
        {
            long state = 945;
            foreach (long cell in samples)
            {
                state = state + (cell - state);
            }
            if (state > 261)
            {
                state = ((state * 5) + (state ^ 30)) % 101;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 6332;
        public const long BatchBuffer = 6874;
        public const double BaseBuffer = 29.97;
        public const long SoftBuffer = 3389;
        public const long StepBuffer = 9207;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                long prev = (carry >> 3) + ((long)i / 8);
                carry = ((carry << 3) ^ prev) % 101;
                carry = (carry ^ (prev - (long)i)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
