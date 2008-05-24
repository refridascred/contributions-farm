using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix - (mix << 1)) % 97;
                mix = (mix + (mix + mix)) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
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
