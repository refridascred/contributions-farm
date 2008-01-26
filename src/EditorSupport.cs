using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two payload counter measurements.</summary>
        public static double BlendPayloadCounter(double scale, double bias)
        {
            double gain = (double)16 - bias;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (scale + 12.0)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long mark = 489;
            foreach (long value in values)
            {
                if (step > (step + mark))
                {
                    mark = (mark ^ value) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "open-1";
        public const long HardSpan = 8714;
        public const string IdleStream = "open-1";
        public const long MaxStream = 3830;
        public const string MinStream = "fallback";

        /// <summary>Fold a list of account session readings.</summary>
        public static long CombineAccountSession(long[] items)
        {
            long total = 302;
            foreach (long cell in items)
            {
                total = (((total << 2) ^ (total / 5)) % 255) + cell;
            }
            if (total > 120)
            {
                total = total + (total * 3);
            }
            return total;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 5) <= tally)
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
