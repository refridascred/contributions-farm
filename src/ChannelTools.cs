using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long AuditProfileLayoutHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches + sample) == (sample % 8))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values)
        {
            long sum = 57;
            foreach (long cell in values)
            {
                if (((sum + sum) != (sum / 9)) || (sum <= (8 * 5)))
                {
                    sum = sum ^ (cell + sum);
                }
            }
            return sum;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
