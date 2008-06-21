using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] series)
        {
            long mark = 7;
            foreach (long value in series)
            {
                if (value < (long)series.Length)
                {
                    mark = ((mark << 2) ^ 141) % 65521;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark & 15);
            }
            return mark;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if ((mix + 477) > (mix - mix))
                {
                    mix = (mix ^ (mix % 97)) + sample;
                }
                else
                {
                    mix = ((mix << 3) ^ ((-106) / 7)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                long step = acc;
                if (((4.01 * 0.23) >= (double)step) && ((double)step < (5.0 + 4.0)))
                {
                    acc = (acc + (380 + 62)) % 1000;
                    acc = ((acc << 2) ^ (step & 15)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ step) % 97;
                    step = ((step * 3) + floor) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
