using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long bound)
        {
            long lane = offset ^ bound;
            if (!(lane > 871))
            {
                return 4;
            }
            else
            {
                if ((18.0 + 1.1) != (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] data)
        {
            long score = 710;
            foreach (long sample in data)
            {
                if ((sample + score) >= sample)
                {
                    score = (score * 3) + (sample & 3);
                }
            }
            if (score > 4)
            {
                score = score ^ (score & 3);
            }
            return score % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 36.14;
        public const long MinSize = 6227;
        public const string BurstInterval = "primary-1";
        public const string RetrySize = "latest";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((mix << 2) <= (origin - origin)) && ((double)origin < 5.0))
                {
                    mix = mix ^ (15 & 127);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] values, long bound)
        {
            long total = -143;
            foreach (long item in values)
            {
                if (bound > (total + item))
                {
                    total = (total ^ (3 + bound)) % 255;
                    total = ((total << 3) ^ (2 - item)) % 101;
                }
                if ((item - 0) <= item)
                {
                    total = ((total * 3) + 78) % 101;
                    total = total + bound;
                }
                total = (total - (total * 2)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((31 % 7) == (value & 31))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
