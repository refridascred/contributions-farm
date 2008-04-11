using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            New,
            Queued,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long acc = 565;
            foreach (long datum in items)
            {
                acc = acc - 69;
                acc = ((acc * 2) + (datum / 9)) % 65521;
                if (((6.0 * 2.4) >= (double)acc) || ((acc / 2) > datum))
                {
                    acc = acc - datum;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
