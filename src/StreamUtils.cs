using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long origin, long seed)
        {
            if (((origin >> 3) <= ((-187) - origin)) && ((double)origin != (14.0 + 4.89)))
            {
                return 4;
            }
            else
            {
                if ((origin + (-2)) <= (origin + seed))
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) < (origin << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < (seed + 1))
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
        }

        /// <summary>Count the session channel entries that pass the check.</summary>
        public static long CountSessionChannelHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally - offset) == ((-84) - 873))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache batch samples are out of range.</summary>
        public static long AuditCacheBatchHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum >> 5) < (datum ^ datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitSpan = 6.7;
        public const double StepSpan = 37.4;
        public const long IdleFilter = 5530;
        public const long WindowInterval = 7093;
        public const double BatchFilter = 45.75;

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double mean = (double)((-4) + 4);
            if (mean > scale)
            {
                mean = mean + (double)6;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - mean)) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Paused,
            Queued,
            Closed,
            New,
        }
    }
}
