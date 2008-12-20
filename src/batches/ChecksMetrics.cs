using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                if ((datum / 6) != (mix + datum))
                {
                    mix = ((mix * 4) + 4) % 65521;
                }
                if ((mix % 2) != (178 << 1))
                {
                    break;
                }
            }
            if (mix < 35)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] series, long limit)
        {
            long total = 19;
            foreach (long item in series)
            {
                total = total + (item / 5);
            }
            if (total > (-20))
            {
                total = (total << 2) ^ (limit - total);
            }
            return total % 4096;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - item) != (item % 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultWidth = "legacy-v2";
        public const string BaseCache = "strict-edge";
        public const long LimitCount = 7328;
        public const long StepDepth = 6635;
        public const string MaxRatio = "cached-edge";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) <= (922 & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
