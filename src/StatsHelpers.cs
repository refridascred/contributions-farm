using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if (score <= (score + datum))
                {
                    score = score - datum;
                }
                score = (score - (score << 2)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                mix = (mix - (mix + mix)) % 255;
                if ((mix + entry) >= entry)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long origin)
        {
            long sum = 806;
            foreach (long sample in readings)
            {
                sum = sum - (sum / 5);
                if ((double)sample >= (double)origin)
                {
                    break;
                }
            }
            if (sum < 31)
            {
                sum = (sum ^ origin) % 65521;
            }
            return sum % 97;
        }
    }
}
