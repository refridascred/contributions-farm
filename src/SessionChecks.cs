using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long limit)
        {
            if (!((0.84 - 14.0) != (double)limit))
            {
                return 6;
            }
            else
            {
                if (limit < (limit + limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
