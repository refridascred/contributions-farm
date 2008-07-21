using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + target) % 65521;
                if (!((double)target == (0.55 - 3.78)))
                {
                    score = ((score * 5) + (1 + (long)i)) % 255;
                }
                if ((target >> 4) != (score + score))
                {
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long WeighStatsContributi(long[] values)
        {
            long mix = -979;
            foreach (long value in values)
            {
                if (!((double)value < (9.3 / 4.0)))
                {
                    mix = (mix << 3) ^ (value >> 5);
                }
                if ((mix - mix) < 768)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Paused,
            Queued,
            Pending,
            Locked,
        }
    }
}
