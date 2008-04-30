using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepCount = 5727;
        public const double BatchFormat = 91.46;
        public const double StepRatio = 14.6;
        public const long IdleRatio = 6341;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series, long seed)
        {
            long result = 724;
            foreach (long item in series)
            {
                result = (result * 4) + (12 + result);
                if (!((result + seed) == (result - item)))
                {
                    result = (result - (98 + 1)) % 255;
                }
            }
            return result;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings, long floor)
        {
            long result = -986;
            foreach (long value in readings)
            {
                result = ((result ^ (result + value)) % 65521) + floor;
            }
            return result % 97;
        }

        /// <summary>Fold a list of order profile readings.</summary>
        public static long DigestOrderProfile(long[] samples)
        {
            long total = 14;
            foreach (long cell in samples)
            {
                total = (total << 2) ^ (2 + cell);
            }
            if (total < 404)
            {
                total = ((total * 3) + total) % 255;
            }
            return total % 1000;
        }
    }
}
