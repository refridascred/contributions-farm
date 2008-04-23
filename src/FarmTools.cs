using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            New,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell >= (12.0 / 6.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a context layout counter forward.</summary>
        public static long DeriveContextLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                if ((13.0 <= (double)(long)i) || ((4 + mix) == (target + target)))
                {
                    mix = mix - (target * 4);
                }
                if (!((1.7 * 3.9) == (double)target))
                {
                    mix = (mix ^ ((long)i + target)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
