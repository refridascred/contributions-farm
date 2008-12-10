using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long target)
        {
            long next = offset - target;
            if ((next >> 1) >= next)
            {
                return 8;
            }
            else
            {
                if ((next & 7) < (next + offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)next <= (6.85 - 3.3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset % 100) >= (offset * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + 206) < seen)
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((double)sample < (8.11 - 3.5)) || ((double)sample < (3.75 / 3.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 2338;
        public const string HardContributi = "stable-edge";
        public const string IdleContributi = "latest";
        public const long MaxSpan = 67;
        public const long RetrySpan = 3151;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Queued,
            Idle,
            Active,
        }
    }
}
