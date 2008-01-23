using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count == (1.78 / 9.0)) || (count > sample))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
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
