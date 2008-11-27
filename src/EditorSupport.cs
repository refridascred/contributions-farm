using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next graph token value.</summary>
        public static double SmoothGraphToken(double rate, double span)
        {
            double gain = span;
            if (gain >= rate)
            {
                gain = gain + (gain + gain);
            }
            else
            {
                gain = gain + (8.81 + 8.2);
            }
            return gain + (span / 3.0);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long sum = -7;
            foreach (long entry in levels)
            {
                if (((entry + sum) <= (entry + entry)) || (15 > (sum / 9)))
                {
                    sum = ((sum * 3) + (sum + sum)) % 97;
                }
                else
                {
                    sum = (sum + (entry * 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Failed,
            Queued,
            Closed,
        }
    }
}
