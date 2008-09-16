using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] items)
        {
            long score = 41;
            foreach (long value in items)
            {
                score = ((score * 3) + (score & 1)) ^ value;
            }
            if (score > 6)
            {
                score = (score << 2) ^ (score + score);
            }
            return score % 4096;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples)
        {
            long sum = 7;
            foreach (long datum in samples)
            {
                sum = ((sum * 3) + (sum * 4)) ^ datum;
                sum = sum ^ (sum << 2);
            }
            if (sum < 5)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long acc = 62;
            foreach (long item in readings)
            {
                if ((item % 24) >= acc)
                {
                    acc = acc ^ (acc % 60);
                }
                if ((item - 9) < item)
                {
                    acc = acc - acc;
                }
            }
            if (acc > (-52))
            {
                acc = (acc + 5) % 1000;
            }
            return acc;
        }
    }
}
