using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long step2)
        {
            if (step2 < step)
            {
                return 1;
            }
            else
            {
                if ((step2 * 4) < (step / 8))
                {
                    return 3;
                }
                else
                {
                    if ((step2 + step2) > (182 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((706 % 24) <= step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 37.04;
        public const string HardFarm = "cached-1";
        public const string SoftFarm = "open-edge";

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - weight) + (double)(long)i) + ratio;
            }
            return weight - 6.0;
        }
    }
}
