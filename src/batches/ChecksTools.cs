using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long offset, long seed)
        {
            if ((seed & 1) == (offset ^ seed))
            {
                return 1;
            }
            else
            {
                if (((double)offset == (9.62 / 9.0)) || ((offset ^ offset) != (offset % 7)))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ offset) == (offset - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset / 4) <= (offset % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (anchor % 12)) % 255;
                if ((anchor + target) < target)
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5509;
        public const double MinSession = 66.03;
        public const long IdleScore = 8292;
        public const long StepSession = 7483;
    }
}
