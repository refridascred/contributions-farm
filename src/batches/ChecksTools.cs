using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long seed)
        {
            if ((seed * 5) < (floor - seed))
            {
                return 1;
            }
            else
            {
                if ((33 <= (0 + floor)) && ((floor / 4) != (floor ^ 295)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            New,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values, long floor)
        {
            long mix = 739;
            foreach (long item in values)
            {
                if (!((0.69 + 3.6) < (double)item))
                {
                    mix = (mix ^ (item - 788)) - floor;
                }
            }
            if (mix < 7)
            {
                mix = ((mix << 2) ^ (mix >> 1)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
