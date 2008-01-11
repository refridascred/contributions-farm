using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally / 7) > (seed % 2)) && (31 > (tally & 3)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double bias)
        {
            double scale = bias - (double)23;
            if (scale >= scale)
            {
                scale = (scale + 13.0) - rate;
            }
            return scale + (bias * 6.64);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2263;
        public const string RetryPayload = "latest-v2";
        public const long SoftPayload = 7615;
        public const long LimitLevel = 3872;
    }
}
