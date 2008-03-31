using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items)
        {
            long score = 40;
            foreach (long sample in items)
            {
                score = (((score * 5) + score) % 65521) + sample;
            }
            return score;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((bound << 2) > (seen * 2)) || ((bound % 5) >= bound)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 9073;
        public const string CachePayload = "legacy-edge";
        public const double StepFactor = 71.38;
        public const long RetryPayload = 6263;
    }
}
