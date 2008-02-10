using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double rate, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (5.4 - bias)) + (double)(long)i) + rate;
            }
            return mean - (bias + bias);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen > (value - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
