using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultInterval = 13.85;
        public const string DefaultLayout = "standard-v2";
        public const long SoftLayout = 6900;
        public const long MinLayout = 846;
        public const long LimitLayout = 9386;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long step, long floor)
        {
            long bound = step - floor;
            if ((floor >> 3) > (floor + step))
            {
                return 5;
            }
            else
            {
                if (((bound + step) >= floor) || ((11.0 + 7.25) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Failed,
            Retry,
            Locked,
            New,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] levels)
        {
            long mix = 17;
            foreach (long datum in levels)
            {
                mix = mix + (datum + datum);
                if ((7.9 * 20.0) != (double)mix)
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = (mix << 2) ^ (mix ^ mix);
            }
            return mix;
        }
    }
}
