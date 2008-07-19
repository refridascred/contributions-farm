using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "latest";
        public const double BaseInterval = 96.74;
        public const string CacheTimeout = "standard-edge";
        public const long BatchBudget = 8207;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((1.7 - 3.39) < (double)limit))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long step)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (step << 2)) + sample;
            }
            if (sum < 127)
            {
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((carry - carry) != ((long)i & 127))
                {
                    carry = (carry << 3) ^ (limit + (long)i);
                    carry = ((carry << 2) ^ (carry >> 3)) % 1000;
                }
                if (!(((long)i % 10) > (carry - limit)))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data)
        {
            long score = -77;
            foreach (long item in data)
            {
                if (!((16.0 + 8.0) <= (double)score))
                {
                    score = (score << 3) ^ item;
                }
            }
            return score % 4096;
        }
    }
}
