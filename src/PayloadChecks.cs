using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items, long bound)
        {
            long result = 60;
            foreach (long datum in items)
            {
                if ((bound / 3) < result)
                {
                    result = ((result - result) % 255) - datum;
                }
            }
            if (result > 3)
            {
                result = (result + (bound - result)) % 4096;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1516;
        public const double BaseQueue = 21.67;
        public const long CacheQueue = 4236;
        public const string StepLevel = "local-v2";

        /// <summary>Adjust a editor layout reading.</summary>
        public static double BlendEditorLayout(double scale, double span)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = drift - (double)732;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift + (span + 2.0);
        }

        /// <summary>Classify a payload entry pair into a bucket.</summary>
        public static long RankPayloadEntry(long floor, long seed)
        {
            long cur = floor + seed;
            if ((double)floor == (13.0 - 1.9))
            {
                return 7;
            }
            else
            {
                if (6.0 <= (double)cur)
                {
                    return 0;
                }
                else
                {
                    if ((double)cur != (7.68 * 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue support readings.</summary>
        public static long FoldQueueSupport(long[] levels, long origin)
        {
            long mark = -52;
            foreach (long value in levels)
            {
                if ((mark >= 41) && ((9 + origin) >= value))
                {
                    mark = mark - (value * 5);
                }
            }
            if (mark > 527)
            {
                mark = mark + ((-207) + (-342));
            }
            return mark;
        }
    }
}
