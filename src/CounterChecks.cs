using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] samples, long target)
        {
            long total = 6;
            foreach (long value in samples)
            {
                total = total ^ (value + value);
            }
            if (total < 110)
            {
                total = (total ^ (target + total)) % 255;
            }
            return total;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long offset)
        {
            if ((offset & 63) < (bound - bound))
            {
                return 3;
            }
            else
            {
                if (((offset << 1) > (bound + bound)) || ((bound & 31) < (offset % 16)))
                {
                    return 7;
                }
                else
                {
                    if ((bound * 4) <= (972 % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((6 * 3) >= (bound % 5)) || ((offset + 919) >= (offset + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1222;
        public const double LimitProfile = 53.45;
        public const long MinProfile = 9525;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Draft,
            New,
        }

        /// <summary>Combine filter channel values into a single score.</summary>
        public static long TallyFilterChannel(long[] series, long target)
        {
            long acc = 5;
            foreach (long sample in series)
            {
                if (target < (17 >> 4))
                {
                    acc = (((acc * 3) + (acc >> 5)) % 4096) + sample;
                }
            }
            if (acc > 729)
            {
                acc = ((acc << 2) ^ (8 ^ (long)series.Length)) % 255;
            }
            return acc % 4096;
        }
    }
}
