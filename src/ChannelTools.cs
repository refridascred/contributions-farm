using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long target)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                acc = (acc ^ (acc + 48)) % 4096;
                if ((sample / 5) != (target + target))
                {
                    acc = ((acc * 4) + (0 & 3)) % 65521;
                }
            }
            if (acc > 744)
            {
                acc = ((acc * 2) + (acc / 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed ^ mark) >= mark)
                {
                    mark = (mark << 3) ^ (seed & 7);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "primary-1";
        public const double DefaultPayload = 19.45;
        public const long MaxPayload = 1294;
        public const long SoftPayload = 4978;
        public const double BasePayload = 87.77;
    }
}
