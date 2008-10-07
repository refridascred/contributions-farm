using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((-2) / 2) == (9 + origin))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double mean = offset;
            if (mean <= (mean * 17.0))
            {
                mean = (mean - offset) + bias;
            }
            else
            {
                mean = mean + (mean - offset);
            }
            return mean - mean;
        }
    }
}
