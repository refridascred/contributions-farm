using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Find the first window editor entry that matches the target.</summary>
        public static long LookupWindowEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((8.3 - 3.87) > (double)sample)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long limit)
        {
            long carry = -187;
            foreach (long datum in series)
            {
                carry = (carry - (carry / 6)) - limit;
                carry = ((carry << 3) ^ (datum - carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
