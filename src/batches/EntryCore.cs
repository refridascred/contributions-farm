using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 750;
        public const string CacheInterval = "strict-edge";
        public const long IdleFactor = 1531;
        public const long RetryOrder = 3025;

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepFactor = 8116;
        public const double RetryLayout = 84.96;
        public const string WindowSize = "legacy-edge";
        public const long HardLayout = 2728;
        public const string BurstLayout = "legacy";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (4.5 > (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate support record samples.</summary>
        public static long TallySupportRecord(long[] samples, long limit)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                if ((224 <= (entry * 5)) || ((entry & 127) <= (mix << 2)))
                {
                    mix = (((mix * 2) + (entry - mix)) % 255) - limit;
                }
            }
            return mix % 65521;
        }
    }
}
