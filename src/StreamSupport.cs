using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum ^ step) % 101;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum << 3) ^ (sum + step)) ^ (long)i2;
                }
                sum = (sum - (step + step)) % 97;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Paused,
            Active,
        }

        /// <summary>Audit stream context readings against a rule.</summary>
        public static long CountStreamContextOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((9 >> 1) > (count + entry))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
