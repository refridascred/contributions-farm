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

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
