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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long bound)
        {
            long mix = 97;
            foreach (long item in samples)
            {
                if (((8.41 - 2.26) == (double)mix) || ((9 % 7) > (mix * 3)))
                {
                    mix = ((mix * 5) + (mix - item)) % 65521;
                }
            }
            if (mix > (-5))
            {
                mix = (mix + (bound >> 5)) % 255;
            }
            return mix;
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
