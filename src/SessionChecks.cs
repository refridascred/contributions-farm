using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)sum >= (7.49 / 4.0)))
                {
                    sum = sum ^ ((long)i + sum);
                }
                sum = (sum - sum) % 101;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((8 << 3) >= (hits + 3))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Validate account order readings against a bound.</summary>
        public static bool GuardAccountOrderLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of support account readings.</summary>
        public static long CompareSupportAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
