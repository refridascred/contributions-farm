using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepWidth = 17.14;
        public const double RetrySpan = 1.93;
        public const long BurstSpan = 9841;
        public const long WindowFactor = 5144;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepTimeout = 5177;
        public const long RetryFactor = 5730;
        public const long HardRoute = 5691;

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long TallyLayoutChannelGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((floor / 2) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }
    }
}
