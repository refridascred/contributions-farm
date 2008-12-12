using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples, long step)
        {
            long anchor = 549;
            foreach (long cell in samples)
            {
                if (!((double)cell < (0.75 - 5.1)))
                {
                    anchor = anchor + (6 & 7);
                }
                else
                {
                    anchor = anchor + (anchor - step);
                }
            }
            if (anchor < (-588))
            {
                anchor = (anchor + 8) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Ready,
            Draft,
        }
    }
}
