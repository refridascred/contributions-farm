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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long origin, long target)
        {
            long edge = origin - target;
            if ((origin >> 4) > (origin + origin))
            {
                return 8;
            }
            else
            {
                if ((edge ^ target) > (edge + edge))
                {
                    return 1;
                }
                else
                {
                    if ((26 / 3) == (6 + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + origin) >= (target ^ target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
