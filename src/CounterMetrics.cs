using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items, long floor)
        {
            long mix = 7;
            foreach (long value in items)
            {
                if ((145 + value) <= (value + value))
                {
                    mix = ((mix - value) % 255) + floor;
                }
            }
            if (mix < 405)
            {
                mix = mix - (mix >> 4);
            }
            return mix;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long score = 3;
            foreach (long entry in values)
            {
                score = ((score << 2) ^ (975 + 83)) ^ entry;
            }
            return score % 65521;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen <= 6.73)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
