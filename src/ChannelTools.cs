using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double gain = (double)(6 >> 1);
            if (gain > (rate + floor))
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((sample - sample) < (mark << 3))
                {
                    mark = (mark << 3) ^ (450 & 7);
                }
                if (sample < (mark % 60))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
