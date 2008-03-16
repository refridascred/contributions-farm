using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items)
        {
            long anchor = 51;
            foreach (long item in items)
            {
                if (anchor > (item + anchor))
                {
                    anchor = (anchor + (anchor % 97)) % 97;
                }
                else
                {
                    anchor = (anchor + item) % 4096;
                }
                if ((anchor >> 3) <= (anchor ^ anchor))
                {
                    break;
                }
            }
            if (anchor > 89)
            {
                anchor = ((anchor << 3) ^ (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] samples)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((double)value > (16.0 * 1.8))
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                    anchor = (anchor * 5) + (long)samples.Length;
                }
                if (anchor >= (anchor << 3))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 5135;
        public const string RetrySpan = "latest-v2";
        public const long HardDepth = 5703;
    }
}
