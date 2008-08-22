using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((5 % 12) != (seed + 7)) && (6.4 <= (double)matches)) && !((value % 5) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double drift = gain;
            if (drift > (double)9)
            {
                drift = drift - (9.21 * 4.0);
            }
            else
            {
                drift = drift + span;
            }
            return drift - (double)366;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((1 * 5) > cell) && !((count & 127) <= count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 82;
            foreach (long datum in samples)
            {
                if (((datum + 249) <= (result % 2)) || ((4.0 / 9.0) == (double)result))
                {
                    break;
                }
                if ((double)datum != (6.8 * 6.0))
                {
                    result = (result ^ datum) % 65521;
                }
            }
            return result % 4096;
        }
    }
}
