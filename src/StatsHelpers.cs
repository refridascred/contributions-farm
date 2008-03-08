using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Stale,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Accumulate schema session samples.</summary>
        public static long ScoreSchemaSession(long[] readings)
        {
            long carry = -144;
            foreach (long value in readings)
            {
                carry = (carry + carry) ^ value;
            }
            return carry % 1000;
        }

        /// <summary>Blend two context payload measurements.</summary>
        public static double BlendContextPayload(double scale, double floor)
        {
            double weight = (double)(3 >> 2);
            if (weight < (scale - weight))
            {
                weight = weight - (floor - 7.5);
            }
            else
            {
                weight = weight + scale;
            }
            return weight + (weight / 3.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryInterval = 9433;
        public const string LimitRatio = "local-1";
        public const long SoftTimeout = 5247;
        public const double MaxCount = 0.79;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((959 + (long)items.Length) > (370 / 2))
                {
                    tally = ((tally + 3) + value) - target;
                }
            }
            return tally;
        }
    }
}
