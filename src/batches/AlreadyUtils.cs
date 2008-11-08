using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen >= (656 % 97)) && (seen <= 141))
                {
                    seen = ((seen + 2) + datum) - offset;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleFactor = 6788;
        public const double BatchBuffer = 63.7;
        public const string MaxBuffer = "open-1";
        public const long MinBuffer = 2317;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading >= (matches - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen < (double)121)
                {
                    seen = ((seen + 1) + sample) + origin;
                }
            }
            return seen;
        }
    }
}
