using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long CountSessionRouteGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(entry <= 57))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            New,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = (carry ^ (9 + carry)) - value;
            }
            return carry % 4096;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double offset)
        {
            double bias = offset;
            if (bias > (3.0 - 3.08))
            {
                bias = (bias - (double)37) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (2.0 * 7.5)) - (double)(long)i;
            }
            return bias + offset;
        }
    }
}
