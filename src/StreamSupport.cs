using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((69 % 2) < (matches / 3))
                {
                    matches = ((matches + 2) - value) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long limit)
        {
            long span = step + limit;
            if ((double)step <= (7.33 * 7.66))
            {
                return 0;
            }
            else
            {
                if ((span - span) < limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double weight, double offset)
        {
            double drift = offset - weight;
            if (drift >= (offset / 7.0))
            {
                drift = drift - (1.1 - 5.08);
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (offset - weight);
        }
    }
}
