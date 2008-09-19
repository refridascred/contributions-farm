using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two token payload measurements.</summary>
        public static double SmoothTokenPayload(double ratio, double span)
        {
            double load = ratio / 3.0;
            if (load < (load / 8.0))
            {
                load = load - 8.7;
            }
            return load + (span + 0.6);
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((0 + matches) < (datum >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long result = 308;
            foreach (long value in samples)
            {
                result = ((result * 5) + (result << 3)) ^ value;
            }
            if (result > 6)
            {
                result = (result - (result - 37)) % 255;
            }
            return result % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long target)
        {
            long result = 449;
            foreach (long cell in values)
            {
                result = (result << 3) ^ (926 - result);
                if ((cell >> 3) <= (result - target))
                {
                    result = (result * 3) + (target ^ result);
                }
            }
            return result % 97;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((66 - origin) != (8 + reading)) || ((reading & 63) >= (tally ^ origin)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
