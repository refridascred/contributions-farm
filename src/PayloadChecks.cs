using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] samples)
        {
            long mark = 109;
            foreach (long datum in samples)
            {
                mark = (mark + (datum + mark)) % 97;
                mark = ((mark * 2) + (3 & 127)) % 255;
                if ((mark / 9) > (datum - datum))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - origin) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum - (9 / 6)) % 101) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
