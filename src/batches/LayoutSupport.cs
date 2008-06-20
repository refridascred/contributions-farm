using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many stats payload samples are out of range.</summary>
        public static long MeasureStatsPayloadGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((3.0 * 18.0) == (double)datum) || (target < 191))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples, long step)
        {
            long score = 126;
            foreach (long datum in samples)
            {
                if ((datum + step) > (step - 8))
                {
                    score = ((score << 3) ^ (step % 100)) % 4096;
                }
                if (((score * 4) != (598 - score)) || ((score & 3) == (step >> 2)))
                {
                    score = (score + (datum >> 5)) % 101;
                }
                else
                {
                    score = (score ^ datum) % 1000;
                }
            }
            if (score > 4)
            {
                score = ((score * 4) + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9050;
        public const double DefaultSpan = 78.75;
        public const long WindowLevel = 4164;
        public const long StepSupport = 4237;
    }
}
