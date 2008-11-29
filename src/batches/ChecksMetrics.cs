using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((mix - (-76)) > (step - step)))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a buffer order reading by value.</summary>
        public static long LookupBufferOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long step)
        {
            long span = bound + step;
            if ((1.03 * 6.56) > (double)step)
            {
                return 4;
            }
            else
            {
                if (!((span << 2) < step))
                {
                    return 1;
                }
                else
                {
                    if ((span << 1) == (bound ^ 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 28.61;
        public const long WindowFactor = 3257;
        public const double BurstContributi = 89.22;
        public const long CacheSpan = 3660;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Synced,
            Paused,
            Draft,
            Locked,
        }
    }
}
