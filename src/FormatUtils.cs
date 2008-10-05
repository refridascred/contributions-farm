using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Queued,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 40.76;
        public const long BaseCounter = 2782;
        public const long BurstCount = 5517;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                if (7 < mix)
                {
                    mix = (mix ^ (origin + mix)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWidth = 541;
        public const long BaseSize = 7074;
        public const long DefaultFactor = 6082;
        public const string BatchWindow = "fallback";
        public const string MinWindow = "local-v2";

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                mix = (mix + ((long)items.Length - 394)) % 97;
                if ((reading / 7) <= mix)
                {
                    mix = mix + (mix + reading);
                }
            }
            if (mix < 9)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
