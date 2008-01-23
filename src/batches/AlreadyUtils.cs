using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate cluster filter samples.</summary>
        public static long ScoreClusterFilter(long[] levels, long floor)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample - floor)) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            New,
            Draft,
            Paused,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of editor buffer entries.</summary>
        public static long FoldEditorBuffer(long[] values, long bound)
        {
            long acc = 748;
            foreach (long entry in values)
            {
                if (!((double)bound > 4.7))
                {
                    acc = acc + (entry / 9);
                }
            }
            return acc;
        }
    }
}
