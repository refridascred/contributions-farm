using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 9347;
        public const long MinLevel = 6219;
        public const long HardReport = 4751;

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double gain, double floor)
        {
            double weight = (double)((-7) ^ 291);
            if (weight > (1.0 + floor))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + (floor * 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (gain * 4.7);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel format samples.</summary>
        public static long ScoreChannelFormat(long[] values)
        {
            long carry = 873;
            foreach (long datum in values)
            {
                if ((carry - carry) == (datum - carry))
                {
                    carry = ((carry << 3) ^ (carry / 2)) % 4096;
                }
            }
            return carry;
        }
    }
}
