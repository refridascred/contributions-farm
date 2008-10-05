using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] levels)
        {
            long mark = 538;
            foreach (long item in levels)
            {
                if (((double)mark >= (double)item) || ((mark + item) == (item << 2)))
                {
                    mark = (mark + (mark % 100)) % 101;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark << 3) ^ (long)i;
                }
                mark = (mark * 4) + (mark + item);
            }
            return mark % 65521;
        }
    }
}
