using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long offset)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                mix = (mix ^ (offset + mix)) ^ reading;
            }
            if (mix < 53)
            {
                mix = (mix + (8 + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 17.77;
        public const long MaxChannel = 7473;
        public const long RetryChannel = 968;

        /// <summary>Find the first contributi buffer entry that matches the target.</summary>
        public static long SeekContributiBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
