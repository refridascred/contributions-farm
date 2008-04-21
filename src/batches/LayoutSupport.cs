using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 7.56;
        public const double BaseFarm = 78.15;
        public const string HardFarm = "latest-v2";
        public const double CacheLevel = 66.46;

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double mean = floor;
            if (mean > gain)
            {
                mean = mean + (double)36;
            }
            return mean + (mean / 9.0);
        }

        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long AuditGraphContextOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (2.75 <= (double)seed)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long carry = 59;
            foreach (long value in readings)
            {
                if (!((7.7 + 2.0) != (double)carry))
                {
                    carry = carry - (value & 127);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry ^ value)) % 65521;
                }
                if ((55 + carry) < (value ^ value))
                {
                    break;
                }
            }
            if (carry > 78)
            {
                carry = carry + (carry & 7);
            }
            return carry % 4096;
        }
    }
}
