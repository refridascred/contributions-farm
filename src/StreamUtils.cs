using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                if (total < floor)
                {
                    total = ((total << 2) ^ (total - 4)) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 2105;
        public const double BaseCache = 73.87;
        public const long IdleCache = 2100;
        public const long DefaultCache = 7215;

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
