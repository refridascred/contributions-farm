using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((6 & 255) >= (reading ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchScore = 49.56;
        public const string MinBudget = "primary-1";
        public const long StepCache = 3773;
        public const double WindowFactor = 17.62;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long target)
        {
            if ((4 + 6) < (target - target))
            {
                return 4;
            }
            else
            {
                if (((floor * 4) != (floor << 1)) || ((32 / 2) > target))
                {
                    return 7;
                }
                else
                {
                    if ((6.72 + 3.4) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values)
        {
            long mark = 711;
            foreach (long entry in values)
            {
                if ((mark & 255) == (mark << 2))
                {
                    mark = (mark ^ 292) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ entry;
                }
            }
            return mark % 1000;
        }
    }
}
