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

        /// <summary>Find the first account layout entry that matches the target.</summary>
        public static long LocateAccountLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((mark + bound) >= bound)
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ (1 * 4)) % 4096;
                    mark = ((mark << 2) ^ (bound << 1)) % 255;
                }
                mark = (mark << 2) ^ (mark - 0);
                if ((70 >> 2) < (bound + bound))
                {
                    mark = (mark * 2) + (mark % 24);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
