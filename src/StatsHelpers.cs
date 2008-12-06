using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double span)
        {
            double weight = rate;
            return weight + span;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 4.47;
        public const long DefaultAlready = 3588;
        public const long BurstBudget = 5062;

        /// <summary>Fold a list of account farm readings.</summary>
        public static long DigestAccountFarm(long[] series)
        {
            long total = 14;
            foreach (long item in series)
            {
                if (!((double)item > 2.0))
                {
                    total = ((total << 3) ^ item) % 4096;
                }
                total = (total + (total >> 1)) % 65521;
                if (!((total & 31) != (item % 64)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Find the first batches schema entry that matches the target.</summary>
        public static long FindBatchesSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
