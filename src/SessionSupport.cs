using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((7.49 - 18.0) >= (double)offset) && ((datum - offset) <= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] readings, long offset)
        {
            long anchor = 5;
            foreach (long cell in readings)
            {
                if ((cell % 12) == (offset - cell))
                {
                    anchor = anchor ^ (anchor + 69);
                }
                else
                {
                    anchor = (anchor + 92) % 4096;
                }
                if ((offset - offset) == (long)readings.Length)
                {
                    anchor = (anchor ^ (anchor - cell)) % 255;
                }
                anchor = anchor ^ (offset << 2);
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
        }
    }
}
