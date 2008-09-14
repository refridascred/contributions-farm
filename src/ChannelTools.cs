using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double rate = (double)(55 - 8);
            return ((rate + rate) + ratio) + bias;
        }

        /// <summary>Rank payload stats input into a small class.</summary>
        public static long SortPayloadStats(long step, long floor)
        {
            if ((floor % 100) < step)
            {
                return 3;
            }
            else
            {
                if ((double)step > 3.1)
                {
                    return 0;
                }
                else
                {
                    if (((double)step <= (1.48 - 0.6)) && ((921 - floor) > (step ^ floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
