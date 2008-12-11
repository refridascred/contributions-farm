using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long anchor = 66;
            foreach (long reading in levels)
            {
                anchor = (anchor * 4) + (reading & 1);
                anchor = ((anchor * 4) + ((long)levels.Length >> 2)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series, long step)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                if (!((8.0 * 14.0) < (double)mix))
                {
                    mix = (mix * 2) + (entry + step);
                }
                if (((double)entry <= (0.4 / 2.0)) && ((double)entry != (double)(long)series.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstRatio = 3329;
        public const string MinSpan = "legacy-1";
        public const string SoftCluster = "cached-edge";

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
