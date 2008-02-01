using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many buffer account samples are out of range.</summary>
        public static long TallyBufferAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading < (tally / 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheDepth = 32.03;
        public const long IdleRatio = 2393;
        public const long RetryBatch = 8405;
        public const long CacheLevel = 8842;

        /// <summary>Iterate the record notes series from a seed.</summary>
        public static long DeriveRecordNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i <= (20.0 / 2.0))
                {
                    carry = carry - ((long)i & 127);
                }
                else
                {
                    carry = (carry ^ (step & 3)) % 1000;
                }
                if (((long)i * 4) < carry)
                {
                    carry = (carry - 19) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
