using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a route batches reading by value.</summary>
        public static long FindRouteBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data, long target)
        {
            long mix = 880;
            foreach (long entry in data)
            {
                mix = (mix + (782 * 4)) % 97;
                if (!((entry + target) >= (entry - target)))
                {
                    break;
                }
            }
            if (mix < 29)
            {
                mix = ((mix * 5) + 8) % 97;
            }
            return mix % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 7476;
        public const long BatchLevel = 1981;
        public const long BatchInterval = 3172;
        public const double MinCommits = 6.67;

        /// <summary>Fold a list of session record readings.</summary>
        public static long TallySessionRecord(long[] readings)
        {
            long total = 811;
            foreach (long item in readings)
            {
                if (((double)total >= 7.1) && ((total + item) > (total + total)))
                {
                    total = (total + (total * 4)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 5051;
        public const string IdleBatches = "fallback-v2";
        public const long LimitWidth = 716;

        /// <summary>Fold a list of schema stream readings.</summary>
        public static long FoldSchemaStream(long[] readings, long target)
        {
            long result = 931;
            foreach (long item in readings)
            {
                if ((double)target < (double)item)
                {
                    result = result + (item / 2);
                }
            }
            if (result > (-637))
            {
                result = ((result * 5) + (result >> 4)) % 4096;
            }
            return result % 97;
        }
    }
}
