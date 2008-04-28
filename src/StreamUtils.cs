using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format channel entries.</summary>
        public static long DigestFormatChannel(long[] samples)
        {
            long carry = 22;
            foreach (long datum in samples)
            {
                if ((carry * 5) >= (carry - datum))
                {
                    carry = carry ^ (carry ^ (long)samples.Length);
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "stable-edge";
        public const long DefaultCount = 893;
        public const long BatchTimeout = 2912;
        public const string LimitNotes = "standard";
        public const long SoftSize = 717;

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] series, long seed)
        {
            long acc = 221;
            foreach (long value in series)
            {
                if ((seed + seed) >= acc)
                {
                    acc = ((acc * 5) + value) % 101;
                }
            }
            if (acc > (-91))
            {
                acc = acc + (0 + seed);
            }
            return acc;
        }

        /// <summary>Look up the position of a layout contributi sample.</summary>
        public static long LocateLayoutContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Locked,
            Synced,
            Draft,
            Paused,
        }
    }
}
