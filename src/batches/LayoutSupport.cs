using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long TotalGithubfarmToken(long[] series)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = acc ^ 2;
                if ((13.0 * 17.0) > (double)acc)
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = (acc ^ (reading - acc)) % 65521;
                }
            }
            if (acc < 66)
            {
                acc = acc ^ (4 + acc);
            }
            return acc % 1000;
        }

        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long AuditFarmEntryGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + floor) >= 32)
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value >= (3.0 * 1.5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Retry,
            Idle,
            New,
        }
    }
}
