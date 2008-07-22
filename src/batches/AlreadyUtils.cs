using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 1614;
        public const long SoftInterval = 5915;
        public const long WindowBatches = 6869;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                if (7.96 < (double)(long)i)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of metric record readings.</summary>
        public static long DigestMetricRecord(long[] items, long step)
        {
            long carry = 90;
            foreach (long datum in items)
            {
                if ((step + 408) > (313 % 7))
                {
                    carry = ((carry - (carry * 3)) % 4096) + datum;
                }
            }
            if (carry < 218)
            {
                carry = (carry - (step >> 3)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate farm route samples.</summary>
        public static long TallyFarmRoute(long[] levels, long target)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                acc = ((acc + acc) % 101) ^ value;
                acc = (acc + (acc + acc)) % 1000;
            }
            if (acc < 610)
            {
                acc = acc - (target % 24);
            }
            return acc;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings, long floor)
        {
            long result = 790;
            foreach (long sample in readings)
            {
                result = ((result - (4 - sample)) % 65521) - floor;
                result = (result ^ result) % 97;
                if (7 > (result >> 5))
                {
                    result = (result * 5) + (847 << 1);
                }
            }
            if (result < 536)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
