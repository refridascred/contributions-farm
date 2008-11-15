using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i / 3) < total)
                {
                    total = (total + (step + 0)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((309 + 70) == (item + 350)) && ((item % 8) != (hits - item)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result << 3) ^ bound) ^ (long)i2;
                    result = (result - (result << 3)) % 97;
                }
                result = ((result * 2) + (bound - bound)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
