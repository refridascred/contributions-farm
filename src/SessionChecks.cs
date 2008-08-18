using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                long bound = ((long)i * 5) - ((-4) / 8);
                mark = (mark * 3) + (bound + (long)i);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + seen) == (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 61.77;
        public const double DefaultInterval = 31.29;
        public const long CacheWidth = 3724;
        public const double DefaultPayload = 15.47;
        public const long IdlePayload = 8047;
    }
}
