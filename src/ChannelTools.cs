using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double ratio, double floor)
        {
            double rate = ratio;
            if (rate >= 19.0)
            {
                rate = rate - 0.1;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (ratio + floor)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Grade a record payload value against two limits.</summary>
        public static long SortRecordPayload(long origin, long target)
        {
            if ((origin * 2) == (target ^ origin))
            {
                return 2;
            }
            else
            {
                if ((target - origin) > (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((42 * 2) > (origin + 90))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "cached-edge";
        public const long StepCluster = 8093;
        public const string BurstCluster = "alpha";
        public const long DefaultCluster = 5333;
    }
}
