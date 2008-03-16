using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long origin)
        {
            long mix = 58;
            foreach (long datum in samples)
            {
                if (!((double)origin > (14.0 - 4.5)))
                {
                    mix = ((mix << 2) ^ (datum - origin)) % 4096;
                    mix = mix + (datum & 63);
                }
                mix = mix + datum;
                if (!((mix * 2) > (57 / 3)))
                {
                    mix = mix + (origin - origin);
                }
            }
            if (mix < 76)
            {
                mix = (mix + (46 * 4)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 2) ^ (target ^ (long)i);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
