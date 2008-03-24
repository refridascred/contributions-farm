using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((7.12 + 0.7) > (double)tally)
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a support notes counter forward.</summary>
        public static long IterateSupportNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if ((1.7 * 1.6) <= (double)step)
                {
                    mix = ((mix << 3) ^ mix) % 255;
                    mix = (mix + mix) % 101;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every profile order entry stays within the limit.</summary>
        public static bool GuardProfileOrderRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                if (((double)mix > (double)(long)items.Length) || ((offset << 3) >= (44 + offset)))
                {
                    mix = mix - (offset / 2);
                }
                else
                {
                    mix = (mix << 2) ^ (mix - reading);
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long target)
        {
            if ((6.69 - 4.46) != (double)floor)
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (5.02 + 2.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 6.68;
        public const long IdleSupport = 1893;
        public const string RetrySize = "cached-v2";
        public const long HardSupport = 6491;
        public const double BatchSupport = 26.06;
    }
}
