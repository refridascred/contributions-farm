using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long target2)
        {
            long step = target + target2;
            if (target2 <= (target - target))
            {
                return 2;
            }
            else
            {
                if (!((step & 15) < target))
                {
                    return 7;
                }
                else
                {
                    if (((target - 709) < (target2 - step)) && (step >= (target2 >> 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)count < (5.41 * 16.0)))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFactor = 14.18;
        public const long LimitTimeout = 7077;
        public const double DefaultFormat = 38.42;
        public const long RetryFormat = 5247;

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((target + seen) == ((-933) * 2))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
