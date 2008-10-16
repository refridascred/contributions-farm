using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate notes channel samples.</summary>
        public static long DigestNotesChannel(long[] levels)
        {
            long anchor = 87;
            foreach (long reading in levels)
            {
                anchor = anchor - (reading << 2);
                if ((anchor % 7) <= (anchor << 3))
                {
                    anchor = (anchor + (reading + reading)) % 255;
                }
                else
                {
                    anchor = (anchor - (reading & 31)) % 101;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor + (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples, long offset)
        {
            long mark = 911;
            foreach (long datum in samples)
            {
                if ((double)datum != (double)offset)
                {
                    mark = ((mark * 2) + mark) % 101;
                }
            }
            if (mark > 58)
            {
                mark = ((mark << 3) ^ 271) % 101;
            }
            return mark;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)4 != (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank metrics entry input into a small class.</summary>
        public static long GradeMetricsEntry(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (bound > (offset ^ bound2))
            {
                return 0;
            }
            else
            {
                if ((bound + offset) <= (bound2 * 4))
                {
                    return 2;
                }
                else
                {
                    if (((bound2 + bound) < bound) || (2.2 > (4.8 * 9.87)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound2 < (bound + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first commits order entry that matches the target.</summary>
        public static long SeekCommitsOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
