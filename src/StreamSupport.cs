using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long mark = -5;
            foreach (long sample in levels)
            {
                if ((sample > (sample & 63)) && (sample > 46))
                {
                    mark = mark + (sample + mark);
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + sample)) % 97;
                }
                mark = ((mark << 3) ^ (mark + sample)) % 4096;
                mark = (mark * 4) + sample;
            }
            return mark;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
