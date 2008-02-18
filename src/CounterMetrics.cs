using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (carry << 2)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two window queue measurements.</summary>
        public static double BlendWindowQueue(double scale, double span)
        {
            double drift = 2.6;
            if (drift <= (drift + 6.0))
            {
                drift = ((drift - (drift + 9.0)) - scale) + span;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Find the first cache session entry that matches the target.</summary>
        public static long LookupCacheSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
