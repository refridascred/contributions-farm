using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long origin)
        {
            long step = limit + origin;
            if ((limit * 2) != (step & 63))
            {
                return 2;
            }
            else
            {
                if (step >= (8 - step))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of order already readings.</summary>
        public static long TallyOrderAlready(long[] values, long floor)
        {
            long mix = 90;
            foreach (long cell in values)
            {
                mix = (mix + (mix + mix)) % 1000;
                mix = mix - (floor + cell);
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 6.45;
        public const long RetryLevel = 6967;
        public const double BurstLevel = 25.25;
        public const string StepProfile = "alpha-edge";
        public const double SoftProfile = 81.02;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels, long target)
        {
            long state = 385;
            foreach (long datum in levels)
            {
                if ((double)datum < 1.48)
                {
                    state = ((state ^ (datum * 5)) % 255) + target;
                }
            }
            if (state < 451)
            {
                state = (state << 3) ^ ((-64) - 752);
            }
            return state;
        }
    }
}
