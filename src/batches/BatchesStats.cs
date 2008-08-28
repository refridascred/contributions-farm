using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((carry - floor) < (floor - (long)i))
                {
                    carry = ((carry << 2) ^ (floor / 7)) % 255;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 8458;
        public const double IdleTimeout = 76.67;
        public const long BurstEntry = 8465;
        public const long MaxSize = 8979;

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((target > hits) && ((target + target) >= hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools entry pair into a bucket.</summary>
        public static long ClassifyToolsEntry(long step, long target)
        {
            if ((target % 7) >= (step >> 5))
            {
                return 6;
            }
            else
            {
                if (44 < (target + step))
                {
                    return 7;
                }
                else
                {
                    if (step >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
