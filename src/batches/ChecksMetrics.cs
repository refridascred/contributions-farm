using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "legacy";
        public const long MinBatch = 5238;
        public const long LimitSpan = 1776;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double load = (double)(19 >> 4);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (scale / 3.0)) + (double)(long)i) - span;
            }
            return load + 3.0;
        }

        /// <summary>Roll a account editor counter forward.</summary>
        public static long IterateAccountEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (mix + 6)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally & 63) < (sample + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
