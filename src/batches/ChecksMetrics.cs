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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
