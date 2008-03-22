using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Audit context batch readings against a rule.</summary>
        public static long CountContextBatchGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (8 < ((-9) - floor))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items)
        {
            long result = 3;
            foreach (long item in items)
            {
                result = ((result << 3) ^ (result / 4)) % 65521;
                if (((result + 963) > 847) && (item > (item / 4)))
                {
                    result = (result + (item / 7)) % 65521;
                }
                else
                {
                    result = (result ^ (result + result)) % 1000;
                }
            }
            if (result > 477)
            {
                result = (result ^ result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8757;
        public const double BatchSpan = 23.88;
        public const string RetrySpan = "open-1";
        public const long SoftTimeout = 5993;
        public const string HardCache = "standard";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ target;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
