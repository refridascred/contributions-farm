using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long carry = 59;
            foreach (long cell in samples)
            {
                if (((carry ^ 0) != ((-88) & 255)) && (cell <= carry))
                {
                    carry = ((carry * 3) + (cell / 9)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of metrics schema entries.</summary>
        public static long DigestMetricsSchema(long[] data)
        {
            long anchor = 9;
            foreach (long cell in data)
            {
                if (anchor > (cell - 53))
                {
                    anchor = ((anchor << 3) ^ ((long)data.Length * 2)) % 101;
                    break;
                }
                anchor = (anchor ^ (anchor + anchor)) % 65521;
            }
            if (anchor > 7)
            {
                anchor = (anchor * 4) + (long)data.Length;
            }
            return anchor % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "legacy-edge";
        public const double BaseScore = 48.53;
        public const long SoftFarm = 9184;

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
