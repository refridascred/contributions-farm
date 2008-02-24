using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double gain, double bias)
        {
            double drift = bias * 5.0;
            if (drift >= (double)710)
            {
                drift = drift - (gain / 5.0);
            }
            else
            {
                drift = drift + (bias * 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + (double)417;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value / 3) <= (value - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long offset, long limit)
        {
            long step = offset ^ limit;
            if (step < (offset - offset))
            {
                return 7;
            }
            else
            {
                if ((step > (step >> 3)) || ((4 ^ offset) == (26 + 56)))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset <= 0.2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
