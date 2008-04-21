using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) >= (3 + tally))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate route format samples.</summary>
        public static long DigestRouteFormat(long[] series, long origin)
        {
            long result = 6;
            foreach (long reading in series)
            {
                if ((double)result < (7.3 - 8.1))
                {
                    result = (result ^ 78) ^ reading;
                }
                if (result <= (origin + 989))
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = ((result << 3) ^ origin) % 101;
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((hits + hits) <= (hits & 63)) || ((value >> 5) > 911)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double ratio = scale;
            if (ratio > ratio)
            {
                ratio = ratio + (scale + ratio);
            }
            return ratio - (ratio + bias);
        }
    }
}
