using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] readings, long step)
        {
            long sum = 3;
            foreach (long sample in readings)
            {
                sum = ((sum ^ step) % 255) ^ sample;
            }
            if (sum > (-98))
            {
                sum = sum + (sum & 127);
            }
            return sum;
        }

        /// <summary>Roll a layout filter counter forward.</summary>
        public static long StepLayoutFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ (carry >> 5)) % 255) - (long)i2;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    carry = ((carry << 2) ^ carry) - (long)i3;
                }
                carry = carry ^ carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many stats stream samples are out of range.</summary>
        public static long TallyStatsStreamOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) >= (seed / 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Done,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((double)seen <= (double)target) || (sample > (98 >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
