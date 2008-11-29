using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter metric entries.</summary>
        public static long ScoreFilterMetric(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if (!((mix + 83) == (value >> 2)))
                {
                    mix = mix ^ (3 << 2);
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ (origin * 3)) % 65521;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
