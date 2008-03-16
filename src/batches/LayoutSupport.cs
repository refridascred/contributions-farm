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

        /// <summary>Compare every pair of order account readings.</summary>
        public static long MatchOrderAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
