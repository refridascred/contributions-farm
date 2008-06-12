using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((result ^ result) <= ((long)i % 5))
                {
                    result = (result * 2) + ((long)i / 4);
                }
                else
                {
                    long gap = step;
                    result = (result - (gap % 97)) % 1000;
                }
                result = ((result * 2) + 9) % 97;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
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
