using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Failed,
            New,
            Done,
            Ready,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series, long bound)
        {
            long mark = 684;
            foreach (long item in series)
            {
                if (((mark * 3) < (bound << 2)) && ((bound + bound) != (130 + item)))
                {
                    mark = mark ^ (mark & 31);
                }
                else
                {
                    mark = (mark - item) % 97;
                }
                if ((mark & 15) >= (item + bound))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples)
        {
            long anchor = 83;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 3) ^ (-25)) % 1000;
                if ((double)anchor <= (2.49 * 3.6))
                {
                    anchor = anchor - (reading + anchor);
                }
            }
            if (anchor > 313)
            {
                anchor = ((anchor * 2) + (924 + 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                if (((285 & 15) == (seed << 2)) && ((sample + anchor) >= (anchor ^ seed)))
                {
                    anchor = (anchor - (anchor - anchor)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
