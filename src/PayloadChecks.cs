using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (state + (-57))) % 65521;
                if ((double)state < (0.66 + 4.6))
                {
                    state = state + state;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many context filter samples are out of range.</summary>
        public static long AuditContextFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (9.25 <= (double)seen)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every report command entry stays within the limit.</summary>
        public static bool CheckReportCommandLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long floor)
        {
            if ((floor << 1) == (bound / 2))
            {
                return 2;
            }
            else
            {
                if ((floor + bound) > bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next schema account value from a seed.</summary>
        public static long SeriesSchemaAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
