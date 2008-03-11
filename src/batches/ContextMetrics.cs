using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double ratio, double offset)
        {
            double ratio2 = offset / 2.0;
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 - (ratio - offset);
            }
            return ratio2 - (ratio2 - 4.8);
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series)
        {
            long mark = 98;
            foreach (long entry in series)
            {
                if (mark >= (mark % 16))
                {
                    mark = (mark - (entry % 16)) % 65521;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark * 4);
            }
            return mark % 1000;
        }
    }
}
