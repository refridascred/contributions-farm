using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double rate = gain + (double)3;
            return (rate - gain) + floor;
        }

        /// <summary>Project the next tools already value.</summary>
        public static double ProjectToolsAlready(double weight, double floor)
        {
            double load = (double)(901 ^ (-155));
            if (load > weight)
            {
                load = (load + (weight / 3.0)) - floor;
            }
            else
            {
                load = load - (load + 8.0);
            }
            return load - 10.0;
        }
    }
}
