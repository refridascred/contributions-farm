using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long seed)
        {
            if (((0.8 * 16.0) <= (double)seed) || ((double)seed < (double)target))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (double)target)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitWidth = 9384;
        public const string HardSpan = "staging-v2";
        public const double LimitSpan = 18.8;
        public const string StepWidth = "strict-v2";

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen ^ reading) > 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a payload already counter forward.</summary>
        public static long DerivePayloadAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix << 2) ^ ((-509) + mix);
                long lane = (4 << 2) & 1;
                if ((lane >> 4) >= lane)
                {
                    lane = ((lane * 2) + (limit + 3)) % 65521;
                }
                else
                {
                    lane = lane + 712;
                    mix = (mix + ((long)i / 2)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
