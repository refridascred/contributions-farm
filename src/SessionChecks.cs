using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long offset)
        {
            long next = bound ^ offset;
            if ((9.9 * 1.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (!((double)1 == (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (offset > (offset * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((423 < (next - bound)) || ((offset + next) <= (offset << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout support readings against a rule.</summary>
        public static long TallyLayoutSupportHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) == (0 - reading))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
