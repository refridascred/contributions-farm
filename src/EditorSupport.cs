using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitSpan = "primary-v2";
        public const long CacheCommand = 3732;
        public const long BaseCommand = 3448;
        public const double MaxFactor = 84.73;
        public const long IdleLevel = 2086;

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a context batch figure with a bias.</summary>
        public static double AdjustContextBatch(double ratio, double floor)
        {
            double scale = floor;
            if (scale < 9.35)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (ratio * 10.0)) - (double)(long)i;
            }
            return scale - (floor / 6.0);
        }
    }
}
