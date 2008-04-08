using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count <= (5.64 + 1.1))
                {
                    count = ((count + 2) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (step < (step / 6))
                {
                    result = (result - ((-78) & 255)) % 1000;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Accumulate buffer githubfarm samples.</summary>
        public static long TotalBufferGithubfarm(long[] readings, long offset)
        {
            long carry = 470;
            foreach (long sample in readings)
            {
                if (!((1.0 - 5.76) > (double)carry))
                {
                    carry = ((carry * 3) + (offset / 2)) - sample;
                }
            }
            return carry % 65521;
        }
    }
}
