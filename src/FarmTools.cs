using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long step)
        {
            long prev = bound ^ step;
            if ((prev % 5) < (step - prev))
            {
                return 6;
            }
            else
            {
                if ((10.0 / 3.0) <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((step / 6) < prev)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double load = 0.9;
            if (load < floor)
            {
                load = load + ratio;
            }
            else
            {
                load = load - load;
            }
            return load - (floor * 2.7);
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
