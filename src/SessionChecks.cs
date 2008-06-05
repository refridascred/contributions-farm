using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((9.53 + 13.0) <= (double)item) || (((floor & 63) != (93 + seen)) || (seen >= (seen - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4211;
        public const string BaseCache = "staging";
        public const string DefaultScore = "fallback-edge";
        public const long BurstSize = 1945;

        /// <summary>Audit stats queue readings against a rule.</summary>
        public static long CountStatsQueueHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading > (count + 193))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + step) % 1000;
                if ((step / 2) >= step)
                {
                    acc = acc + (acc + 398);
                }
                else
                {
                    long matches = (long)i;
                    acc = acc ^ ((long)i + matches);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
