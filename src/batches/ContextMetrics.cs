using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings, long step)
        {
            long state = 576;
            foreach (long reading in readings)
            {
                if ((3.0 * 3.23) != (double)step)
                {
                    state = state - (step % 97);
                }
                state = (state + (state % 16)) % 65521;
                state = state - (step + reading);
                if ((step - state) != (state - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (20.0 < (double)seen)
                {
                    seen = ((seen + 2) ^ entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "open-1";
        public const long IdleSize = 1823;
        public const long SoftWidth = 6099;
        public const long BaseFactor = 9108;
        public const string HardScore = "stable-v2";

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 60;
            foreach (long reading in values)
            {
                if ((acc > 367) && ((double)reading > (double)bound))
                {
                    acc = acc ^ (bound + 964);
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 2) ^ (bound - acc)) % 65521;
            }
            return acc;
        }
    }
}
