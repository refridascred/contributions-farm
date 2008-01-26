using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two payload counter measurements.</summary>
        public static double BlendPayloadCounter(double scale, double bias)
        {
            double gain = (double)16 - bias;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (scale + 12.0)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long seed)
        {
            if ((double)seed != (11.0 + 8.0))
            {
                return 3;
            }
            else
            {
                if (!((8.62 - 4.31) == (double)target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "open-1";
        public const long HardSpan = 8714;
        public const string IdleStream = "open-1";
        public const long MaxStream = 3830;
        public const string MinStream = "fallback";

        /// <summary>Validate already buffer readings against a bound.</summary>
        public static bool VerifyAlreadyBufferRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 5) <= tally)
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
