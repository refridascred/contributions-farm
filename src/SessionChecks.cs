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

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] values, long bound)
        {
            long mark = 6;
            foreach (long item in values)
            {
                if ((bound % 5) <= bound)
                {
                    mark = ((mark << 2) ^ (bound & 127)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (item << 1)) % 255;
                }
            }
            if (mark > 46)
            {
                mark = (mark ^ (bound - mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 3) ^ (824 - (-77));
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
