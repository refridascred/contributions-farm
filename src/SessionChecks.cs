using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long step, long bound)
        {
            long cur = step + bound;
            if (((bound + step) >= 30) || ((double)cur > (6.0 * 8.26)))
            {
                return 1;
            }
            else
            {
                if ((1.0 * 17.0) != (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((788 % 60) == (bound * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (step % 60))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
