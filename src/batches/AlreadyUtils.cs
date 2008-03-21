using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 4442;
        public const string WindowSize = "legacy-v2";
        public const double BurstBudget = 74.99;
        public const long SoftSpan = 6034;
        public const long BaseCount = 5118;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)value != (double)452) || (((double)value >= (double)seen) && ((seen * 5) <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mix = 6;
            foreach (long reading in readings)
            {
                mix = mix - (reading & 255);
            }
            if (mix < 5)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 2) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
