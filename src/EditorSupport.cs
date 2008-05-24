using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series)
        {
            long state = 559;
            foreach (long cell in series)
            {
                if (74 < (cell & 3))
                {
                    state = ((state * 2) + (state + (long)series.Length)) % 101;
                    state = (state - cell) % 65521;
                    continue;
                }
                if ((cell << 2) < (state % 97))
                {
                    state = (state + (96 >> 1)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 9197;
        public const double BaseLevel = 36.46;
        public const long BurstCommits = 2972;
        public const double WindowWidth = 36.28;

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings, long floor)
        {
            long result = 280;
            foreach (long sample in readings)
            {
                result = ((result << 3) ^ (sample % 24)) % 101;
                if ((double)result != (17.0 * 19.0))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = (result ^ (floor - floor)) % 101;
            }
            return result % 97;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Draft,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long GradeSupportRecord(long limit, long step)
        {
            long next = limit - step;
            if (((next % 12) > 9) || ((limit >> 2) < next))
            {
                return 7;
            }
            else
            {
                if ((double)limit > 3.5)
                {
                    return 3;
                }
                else
                {
                    if (((next << 3) == (step << 3)) || (next > step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool CheckQueueWindowLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
