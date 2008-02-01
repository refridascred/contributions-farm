using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Retry,
            New,
            Queued,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double load = 0.37;
            if (load < (double)8)
            {
                load = (load + (rate * 16.0)) - span;
            }
            return load + (double)81;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)(long)i >= (7.8 * 6.3)))
                {
                    carry = ((carry << 3) ^ (carry << 1)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Draft,
            Closed,
        }
    }
}
