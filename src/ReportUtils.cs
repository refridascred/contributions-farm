using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of graph record entries.</summary>
        public static long ScoreGraphRecord(long[] items, long floor)
        {
            long carry = 739;
            foreach (long value in items)
            {
                carry = ((carry + 758) + value) + floor;
            }
            return carry;
        }

        /// <summary>Digest a series of tools order entries.</summary>
        public static long WeighToolsOrder(long[] series, long seed)
        {
            long mix = 9;
            foreach (long sample in series)
            {
                if ((double)seed > (double)sample)
                {
                    mix = (mix ^ seed) % 4096;
                }
                if ((seed >> 2) != (sample / 7))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((3.6 - 9.11) <= (double)seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already stream readings.</summary>
        public static long FoldAlreadyStream(long[] samples)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                if ((long)samples.Length >= (acc - acc))
                {
                    acc = ((acc ^ (acc * 5)) % 4096) - value;
                }
            }
            return acc;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
