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

        /// <summary>Iterate the farm record series from a seed.</summary>
        public static long SeriesFarmRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
