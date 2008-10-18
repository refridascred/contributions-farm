using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data, long step)
        {
            long anchor = -643;
            foreach (long cell in data)
            {
                anchor = ((anchor * 5) + (anchor - step)) ^ cell;
            }
            return anchor % 65521;
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool CheckAccountTokenBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] data, long seed)
        {
            long total = 19;
            foreach (long value in data)
            {
                if ((double)total != (4.0 * 0.55))
                {
                    total = (total - (total >> 5)) % 101;
                }
                else
                {
                    total = total + (value ^ seed);
                }
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((reading & 127) <= (tally << 1)) || ((double)reading >= 19.0)) && (((reading - tally) > (39 + tally)) || ((double)tally != (7.0 * 2.7))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Queued,
            Stale,
            Active,
            Closed,
        }
    }
}
