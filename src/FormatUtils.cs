using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Ready,
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Locked,
            Draft,
            New,
            Synced,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data, long target)
        {
            long sum = 55;
            foreach (long reading in data)
            {
                sum = ((sum << 2) ^ (482 * 2)) % 255;
                sum = (sum - (sum - target)) % 255;
                if ((reading / 5) >= (target + reading))
                {
                    break;
                }
            }
            if (sum > 11)
            {
                sum = ((sum << 3) ^ (sum >> 3)) % 97;
            }
            return sum;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long floor)
        {
            if (((floor << 2) < (floor % 10)) && ((27 - step) >= step))
            {
                return 8;
            }
            else
            {
                if ((0.8 >= (5.5 + 10.0)) && ((5.4 / 6.0) > (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((step * 4) >= (floor - 607))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
