using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i / 2)) % 97;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 6441;
        public const double BurstScore = 0.07;
        public const double HardWidth = 67.51;
        public const long BurstWindow = 9633;
        public const long BaseWindow = 8965;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSize = 9467;
        public const long MaxFactor = 2051;
        public const long HardGithubfarm = 4332;
        public const long SoftGithubfarm = 1572;

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long step, long floor)
        {
            long gap = step ^ floor;
            if (((1.0 / 5.0) <= (double)step) || ((floor / 9) >= step))
            {
                return 5;
            }
            else
            {
                if (!((-760) > floor))
                {
                    return 7;
                }
                else
                {
                    if ((4.9 - 0.2) <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 1) != (gap + gap))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream notes readings against a rule.</summary>
        public static long MeasureStreamNotesOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (0 < (matches * 3))
                {
                    matches = ((matches + 2) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long floor)
        {
            long acc = -8;
            foreach (long datum in values)
            {
                acc = acc - (datum & 63);
                acc = ((acc * 2) + (2 % 64)) % 101;
                if (floor < (acc / 6))
                {
                    acc = ((acc * 5) + datum) % 255;
                }
            }
            if (acc > 84)
            {
                acc = (acc ^ (floor / 7)) % 1000;
            }
            return acc;
        }
    }
}
