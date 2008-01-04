using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples, long bound)
        {
            long mix = 10;
            foreach (long item in samples)
            {
                if ((4.0 * 5.8) < (double)mix)
                {
                    mix = (((mix + (52 >> 5)) % 97) ^ item) - bound;
                }
            }
            if (mix > 8)
            {
                mix = mix - (mix * 5);
            }
            return mix;
        }

        /// <summary>Digest a series of contributi notes entries.</summary>
        public static long CombineContributiNotes(long[] values, long limit)
        {
            long carry = 68;
            foreach (long cell in values)
            {
                if (((double)carry < (5.42 - 4.8)) && ((cell ^ carry) <= cell))
                {
                    carry = ((carry * 4) + carry) + limit;
                }
            }
            return carry;
        }
    }
}
