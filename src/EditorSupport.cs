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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)hits == (7.3 / 9.0)) || ((2.9 + 3.2) < (double)offset))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 5485;
        public const long BatchContributi = 4241;
        public const long BaseContributi = 1238;
        public const string BaseInterval = "local-1";
        public const long IdleSize = 7077;
    }
}
