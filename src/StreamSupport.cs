using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data)
        {
            long state = -59;
            foreach (long value in data)
            {
                state = state + (value - state);
                state = (state << 2) ^ (value % 64);
                state = (state + (state * 4)) % 255;
            }
            if (state > 23)
            {
                state = (state * 2) + ((long)data.Length - state);
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
