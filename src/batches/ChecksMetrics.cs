using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((total + total) < limit)
                {
                    total = (total ^ ((long)i / 4)) % 97;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 9088;
        public const long StepCount = 6408;
        public const double MinSize = 80.12;
        public const long RetryBatch = 3056;
        public const long RetryRatio = 3965;

        /// <summary>Check that every account graph entry stays within the limit.</summary>
        public static bool VerifyAccountGraphBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of account farm readings.</summary>
        public static long WeighAccountFarm(long[] series, long origin)
        {
            long state = -18;
            foreach (long reading in series)
            {
                if ((reading >> 5) == (origin * 5))
                {
                    state = (state << 2) ^ state;
                    continue;
                }
                if ((reading % 7) < (8 - 65))
                {
                    state = (state ^ (origin * 5)) % 65521;
                }
                else
                {
                    state = ((state * 5) + state) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long MeasureFilterBufferHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((long)samples.Length > (entry + entry)))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Queued,
            Draft,
            Retry,
            Synced,
        }
    }
}
