using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a context profile sample.</summary>
        public static long FindContextProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long seed)
        {
            long cur = origin + seed;
            if ((seed - (-8)) != (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((seed >> 2) == (origin * 4))
                {
                    return 8;
                }
                else
                {
                    if ((22 >> 3) == (91 ^ cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed + 72) != (seed << 2)) || ((double)origin != (double)seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit editor entry readings against a rule.</summary>
        public static long AuditEditorEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((23 + matches) < matches) || (((cell % 2) >= (matches >> 4)) && ((matches >> 5) == (6 - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
