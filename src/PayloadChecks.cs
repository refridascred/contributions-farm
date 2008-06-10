using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Failed,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Match up metrics account samples.</summary>
        public static long MatchMetricsAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3984;
        public const long CacheBudget = 3970;
        public const string BurstStats = "cached-v2";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark << 3) ^ (step + step);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
