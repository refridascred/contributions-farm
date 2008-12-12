using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long bound, long target)
        {
            long next = bound + target;
            if ((bound + next) <= (next ^ next))
            {
                return 0;
            }
            else
            {
                if (!((next - bound) >= (bound >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= (1.0 * 9.5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3.0 * 3.69) > (double)bound) && (next < (bound & 127)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
