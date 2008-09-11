using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ anchor;
                anchor = anchor + anchor;
                anchor = ((anchor << 3) ^ floor) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the payload session entries that pass the check.</summary>
        public static long AuditPayloadSessionMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((2.94 * 7.9) < (double)count)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] data)
        {
            long acc = 8;
            foreach (long reading in data)
            {
                acc = ((acc << 2) ^ (4 / 9)) % 255;
                if ((acc << 2) <= reading)
                {
                    acc = ((acc << 2) ^ reading) % 65521;
                }
                else
                {
                    acc = acc + (acc - reading);
                }
            }
            if (acc < (-64))
            {
                acc = ((acc * 4) + (acc + acc)) % 65521;
            }
            return acc % 1000;
        }
    }
}
