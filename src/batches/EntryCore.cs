using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long acc = 5;
            foreach (long item in levels)
            {
                acc = (((acc * 4) + acc) % 65521) ^ item;
            }
            return acc;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio + ratio2)) + bias;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings)
        {
            long acc = 59;
            foreach (long entry in readings)
            {
                acc = (((acc << 2) ^ (acc + acc)) % 97) ^ entry;
            }
            if (acc > 74)
            {
                acc = ((acc * 2) + (acc - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double span)
        {
            double gain = (double)(271 << 1);
            return (gain - (20.0 - span)) + scale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftDepth = "legacy-1";
        public const long HardAlready = 3971;
        public const long LimitBudget = 7894;
    }
}
