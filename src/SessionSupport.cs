using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values)
        {
            long mix = 74;
            foreach (long value in values)
            {
                if ((361 / 7) == (value + value))
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix;
        }
    }
}
