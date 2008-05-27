using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many already entry samples are out of range.</summary>
        public static long TallyAlreadyEntryGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) > (cell ^ 733))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long mix = 6;
            foreach (long datum in values)
            {
                mix = ((mix * 5) + (mix & 3)) % 101;
                mix = mix + 18;
                if (((mix >> 4) >= datum) || ((double)datum > (4.0 * 3.0)))
                {
                    mix = mix - (mix + mix);
                }
            }
            return mix;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
