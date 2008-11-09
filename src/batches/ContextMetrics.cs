using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long carry = 95;
            foreach (long sample in samples)
            {
                if (((carry * 5) <= (8 % 3)) && ((2 + limit) <= (limit << 2)))
                {
                    carry = (carry - (limit - sample)) % 1000;
                }
            }
            if (carry > 1)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double span)
        {
            double mean = span;
            if (mean >= 1.21)
            {
                mean = mean - (scale + mean);
            }
            else
            {
                mean = mean - (4.0 - scale);
            }
            return mean + 7.07;
        }
    }
}
