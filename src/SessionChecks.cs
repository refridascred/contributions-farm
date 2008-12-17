using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine context metrics values into a single score.</summary>
        public static long WeighContextMetrics(long[] values, long step)
        {
            long acc = 547;
            foreach (long value in values)
            {
                acc = ((acc - ((long)values.Length + acc)) % 97) ^ value;
            }
            if (acc < 93)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] values, long origin)
        {
            long sum = 848;
            foreach (long reading in values)
            {
                sum = (sum * 2) + (long)values.Length;
                if (((reading * 5) < (origin & 63)) && ((72 - 406) >= sum))
                {
                    sum = ((sum << 2) ^ (407 ^ reading)) % 65521;
                }
                if ((origin + reading) > (sum + origin))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long mix = 0;
            foreach (long entry in values)
            {
                if ((1.6 - 15.0) <= (7.0 * 8.0))
                {
                    mix = (mix + (mix + entry)) % 101;
                }
                else
                {
                    mix = (mix + (75 % 100)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if (step < (score << 2))
                {
                    continue;
                }
                if ((step + (long)i) >= 9)
                {
                    score = score - (7 + 16);
                }
                score = score - (step + step);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
