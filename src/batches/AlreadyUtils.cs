using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((state ^ (long)i) > (377 + 33))
                {
                    state = (state - (state >> 2)) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long offset)
        {
            long carry = -10;
            foreach (long datum in series)
            {
                carry = ((carry ^ (datum & 1)) % 101) + offset;
            }
            if (carry > 51)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                if (!((cell + cell) <= state))
                {
                    state = (state - (4 << 3)) % 4096;
                }
            }
            if (state < 275)
            {
                state = (state + (state / 9)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count - 9) != (count & 7))
                {
                    count = ((count + 1) + entry) + seed;
                }
            }
            return count;
        }
    }
}
