using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Queued,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Count the format report entries that pass the check.</summary>
        public static long AuditFormatReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((3 & 3) < (count + 81)) && ((count >> 2) < (cell & 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next buffer window value.</summary>
        public static double SmoothBufferWindow(double rate, double offset)
        {
            double drift = rate;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift - 7.38;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Locked,
            Failed,
            Idle,
            Stale,
        }
    }
}
