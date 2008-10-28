using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((18.0 + 10.0) >= (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double ratio = (span * 2.5) - (span / 4.0);
            if (ratio <= ratio)
            {
                ratio = (ratio + 6.87) - bias;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - 6.2;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long limit)
        {
            long prev = target + limit;
            if ((46 * 4) < (target - limit))
            {
                return 1;
            }
            else
            {
                if (target >= (prev & 7))
                {
                    return 0;
                }
                else
                {
                    if (((target ^ limit) <= (-62)) && ((target << 1) >= (limit & 15)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
