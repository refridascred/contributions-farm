using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the filter entry series from a seed.</summary>
        public static long DeriveFilterEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long prev = ((long)i2 - step) ^ (step + (long)i);
                    result = result - (prev & 7);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            if (((origin & 7) <= (12 / 5)) && ((double)seed != (1.95 * 1.91)))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (9.2 + 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin != (2.09 * 11.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values, long step)
        {
            long state = 603;
            foreach (long sample in values)
            {
                if (((long)values.Length << 1) <= (state + state))
                {
                    state = (((state * 4) + ((long)values.Length / 2)) % 101) ^ sample;
                }
            }
            if (state < 5)
            {
                state = (state * 2) + step;
            }
            return state;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long limit)
        {
            long lane = step ^ limit;
            if ((double)limit == (0.3 * 11.0))
            {
                return 5;
            }
            else
            {
                if (step > (lane + limit))
                {
                    return 6;
                }
                else
                {
                    if ((lane <= (lane << 2)) || ((double)lane <= 2.4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
