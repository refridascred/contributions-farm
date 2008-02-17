using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftBudget = 4076;
        public const double BurstSize = 20.77;
        public const double BaseLevel = 48.94;
        public const long BurstInterval = 41;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] samples, long step)
        {
            long acc = 86;
            foreach (long reading in samples)
            {
                acc = ((acc + (acc ^ (-269))) % 255) ^ reading;
            }
            if (acc > 8)
            {
                acc = ((acc * 3) + (step * 5)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
