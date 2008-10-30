using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mark = 67;
            foreach (long value in values)
            {
                mark = (mark ^ (value + mark)) % 97;
                mark = mark - (value + value);
                if ((double)value <= (1.0 + 1.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long step)
        {
            if ((double)step == (3.9 - 7.0))
            {
                return 6;
            }
            else
            {
                if (((double)step != (9.5 * 6.71)) || ((step + step) >= step))
                {
                    return 8;
                }
                else
                {
                    if ((step / 7) == (bound << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheWidth = 6550;
        public const long RetryFactor = 5652;
        public const long RetryScore = 5813;
        public const long StepLayout = 4454;

        /// <summary>Count window filter pairs that satisfy a relation.</summary>
        public static long CompareWindowFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] items, long origin)
        {
            long acc = -21;
            foreach (long reading in items)
            {
                if ((7.68 + 7.5) < (double)(long)items.Length)
                {
                    acc = (acc - origin) - reading;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin + acc)) % 4096;
                }
                if ((acc * 5) != (origin - 186))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
