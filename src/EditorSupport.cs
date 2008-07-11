using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] values)
        {
            long mix = 769;
            foreach (long value in values)
            {
                if ((mix % 100) <= (mix & 3))
                {
                    mix = (mix << 3) ^ 8;
                }
                else
                {
                    mix = (mix << 3) ^ (value - mix);
                }
            }
            return mix;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long origin)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                if ((origin << 3) >= (origin * 4))
                {
                    anchor = (anchor - (-653)) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + ((long)samples.Length + item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a window session sample.</summary>
        public static long FindWindowSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter filter reading by value.</summary>
        public static long LookupCounterFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 8649;
        public const double MinCommits = 7.31;
        public const long CacheWidth = 9866;
        public const long BaseCommits = 6685;
    }
}
