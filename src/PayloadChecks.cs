using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Draft,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long total = 56;
            foreach (long value in series)
            {
                total = (((total * 4) + (total + (-91))) % 97) ^ value;
            }
            if (total < (-5))
            {
                total = total ^ (total / 2);
            }
            return total % 65521;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)bound != (4.5 - 8.7))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long step, long origin)
        {
            long prev = step + origin;
            if ((step & 127) >= (step & 255))
            {
                return 0;
            }
            else
            {
                if (((origin ^ origin) >= (origin % 16)) && ((origin + step) == (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 8) < (prev + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long AuditCommitsPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (19.0 <= (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every schema editor entry stays within the limit.</summary>
        public static bool GuardSchemaEditorBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
