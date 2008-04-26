using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double weight = (double)((-20) << 1);
            if (weight >= span)
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (12.0 - weight)) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseScore = 45.27;
        public const string DefaultSpan = "open-1";
        public const string BatchContext = "fallback";
        public const long BurstContext = 3670;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (((result << 2) ^ (result ^ result)) % 4096) ^ cell;
            }
            return result % 4096;
        }
    }
}
