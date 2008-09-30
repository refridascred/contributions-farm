using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Queued,
            New,
            Draft,
        }

        /// <summary>Derive the next payload githubfarm value from a seed.</summary>
        public static long SeriesPayloadGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix << 3) ^ seed) % 101) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data, long step)
        {
            long total = 53;
            foreach (long cell in data)
            {
                if ((step << 2) == (cell + total))
                {
                    total = (total ^ (7 + cell)) % 255;
                }
                if ((double)(-28) <= (double)total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Validate report entry readings against a bound.</summary>
        public static bool GuardReportEntryBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate farm profile readings against a bound.</summary>
        public static bool ValidateFarmProfileBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
