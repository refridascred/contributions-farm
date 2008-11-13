using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 85.38;
        public const double BatchWidth = 53.57;
        public const long LimitSession = 2841;
        public const long RetryScore = 9655;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 1;
            foreach (long reading in readings)
            {
                mix = (mix - (reading + reading)) % 1000;
            }
            if (mix > 286)
            {
                mix = mix - (mix + 4);
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items)
        {
            long acc = 60;
            foreach (long sample in items)
            {
                if (!(sample > (sample * 5)))
                {
                    acc = (acc + (acc * 4)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 29.2;
        public const long SoftRatio = 9197;
        public const double BurstTimeout = 61.43;
    }
}
