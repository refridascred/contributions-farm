using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Draft,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 3) <= (cell & 255))
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = sum + (sum / 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
