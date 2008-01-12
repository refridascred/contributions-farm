using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] samples)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = acc ^ (acc + (long)i);
                    acc = (acc << 3) ^ (acc + 2);
                }
                acc = (acc + (entry << 3)) % 255;
            }
            if (acc < 77)
            {
                acc = (acc ^ (acc - acc)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next command queue value from a seed.</summary>
        public static long RollCommandQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (limit + 7);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches ^ 775) != (sample - matches)) || ((0.1 * 3.92) != (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
