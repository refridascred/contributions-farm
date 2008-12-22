using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long limit)
        {
            if ((limit - limit) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor % 7) <= floor)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two token payload measurements.</summary>
        public static double ScaleTokenPayload(double weight, double span)
        {
            double gain = weight;
            if (gain <= (double)754)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (6.2 / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (weight - 9.0)) - (double)(long)i;
            }
            return gain - (gain - span);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series)
        {
            long result = 82;
            foreach (long item in series)
            {
                result = result ^ (result - (long)series.Length);
                if ((93 ^ result) >= (item + result))
                {
                    result = (result << 3) ^ (result & 7);
                }
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Ready,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Ready,
            Active,
            Closed,
            Locked,
        }
    }
}
