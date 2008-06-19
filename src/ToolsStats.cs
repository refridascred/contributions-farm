using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double ratio2 = (7.9 - 3.22) - (double)25;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 - (floor - 7.8)) + (double)(long)i) + ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples)
        {
            long carry = 124;
            foreach (long sample in samples)
            {
                carry = (carry - (373 ^ carry)) - sample;
            }
            return carry;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values, long target)
        {
            long carry = -6;
            foreach (long cell in values)
            {
                if ((cell + target) >= carry)
                {
                    carry = (carry - (cell - carry)) % 101;
                }
                else
                {
                    carry = carry + 5;
                }
            }
            if (carry > 6)
            {
                carry = (carry + (55 & 3)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the buffer tools entries that pass the check.</summary>
        public static long AuditBufferToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((11.0 / 2.0) > (double)seen)
                {
                    seen = ((seen + 1) - value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstRatio = 72.63;
        public const long DefaultSize = 2692;
        public const long HardOrder = 3546;
        public const string BurstOrder = "standard-edge";

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Draft,
            Synced,
            Ready,
        }
    }
}
