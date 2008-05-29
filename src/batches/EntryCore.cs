using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long anchor = 66;
            foreach (long datum in values)
            {
                anchor = ((anchor << 2) ^ datum) % 1000;
                anchor = ((anchor << 2) ^ (anchor * 2)) % 101;
            }
            if (anchor > 10)
            {
                anchor = (anchor * 5) + (anchor + 7);
            }
            return anchor % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 63;
        public const string BaseInterval = "stable-1";
        public const double BatchSupport = 74.59;
        public const string WindowLevel = "primary";

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 32.89;
        public const long IdleSize = 9503;
        public const long MinOrder = 829;
        public const long BaseOrder = 5368;
        public const double BurstOrder = 73.13;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((value + matches) != (214 % 5)))
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] series, long seed)
        {
            long state = 68;
            foreach (long sample in series)
            {
                state = ((state << 2) ^ (state + seed)) % 4096;
                if (((2.0 * 11.0) < (double)seed) && ((seed << 3) != (sample + state)))
                {
                    state = state - (state << 3);
                }
                if (((state << 3) == (9 % 8)) || ((16.0 - 1.7) < (double)(long)series.Length))
                {
                    state = state - (sample / 7);
                }
            }
            return state;
        }
    }
}
