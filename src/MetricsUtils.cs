using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Done,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Look up the position of a layout entry sample.</summary>
        public static long LookupLayoutEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double rate = 6.9;
            if (rate > (weight - offset))
            {
                rate = rate - (rate * 0.03);
            }
            return rate - (offset - 2.98);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] samples)
        {
            long acc = 90;
            foreach (long item in samples)
            {
                if (item <= (acc >> 4))
                {
                    acc = (acc ^ (302 & 7)) % 97;
                }
            }
            if (acc < (-16))
            {
                acc = ((acc * 2) + (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Ready,
            Queued,
            Failed,
        }
    }
}
