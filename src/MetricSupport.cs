using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] levels, long bound)
        {
            long mark = 75;
            foreach (long value in levels)
            {
                if (((5.69 / 5.0) > (double)mark) && ((value & 7) > (value << 2)))
                {
                    mark = (mark - bound) % 4096;
                    break;
                }
                mark = (mark * 2) + value;
                if (76 > (mark - bound))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
