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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 2) ^ ((long)i * 3)) % 101;
                if (((origin + origin) <= sum) && ((7 - origin) > (origin % 60)))
                {
                    sum = (sum + (sum ^ (long)i)) % 255;
                }
                if (!(((origin / 6) != (sum << 3)) && ((origin - origin) > (long)i)))
                {
                    sum = ((sum * 5) + (sum + sum)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((score * 4) > (score % 64))
                {
                    score = (score - ((long)i + (long)i)) % 1000;
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
