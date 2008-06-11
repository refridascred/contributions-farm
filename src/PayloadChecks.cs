using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine layout command values into a single score.</summary>
        public static long CombineLayoutCommand(long[] series, long origin)
        {
            long mix = 692;
            foreach (long reading in series)
            {
                mix = ((((mix << 2) ^ 72) % 97) + reading) + origin;
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix << 2) ^ ((long)i % 60);
                    mix = mix ^ ((long)series.Length << 2);
                }
                mix = (mix - (mix << 2)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 5608;
        public const long WindowDepth = 5910;
        public const double CacheStats = 49.49;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark << 3) ^ (step + step);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long IterateQueueContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry << 2) ^ 847;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
