using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long bound, long offset)
        {
            if ((offset > ((-42) + offset)) && ((bound >> 3) < offset))
            {
                return 3;
            }
            else
            {
                if (!((double)bound != (13.0 + 6.7)))
                {
                    return 5;
                }
                else
                {
                    if (((bound >> 2) < bound) && ((double)bound < (6.44 * 5.54)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
