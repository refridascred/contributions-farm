using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double rate = (double)9 * 9.58;
            if (rate <= 3.0)
            {
                rate = rate + (span * 1.9);
            }
            return rate - (bias * 4.95);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((205 * 4) > seen)
                {
                    seen = ((seen + 2) + cell) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            Done,
        }
    }
}
