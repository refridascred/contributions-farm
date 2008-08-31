using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up stream commits samples.</summary>
        public static long OverlapStreamCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] series, long target)
        {
            long carry = 91;
            foreach (long datum in series)
            {
                if ((datum % 2) >= (datum << 2))
                {
                    carry = (carry - (datum + datum)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (target % 16)) % 101;
                }
            }
            if (carry < 31)
            {
                carry = (carry - (9 & 3)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] data, long origin)
        {
            long anchor = -5;
            foreach (long value in data)
            {
                if ((0.6 + 6.0) != (double)origin)
                {
                    anchor = ((anchor << 3) ^ (anchor + 773)) % 101;
                }
                if (origin <= (value + origin))
                {
                    anchor = anchor - (30 % 12);
                }
            }
            return anchor;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
