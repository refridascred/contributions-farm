using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double scale = span * 4.2;
            if (scale > gain)
            {
                scale = scale + (double)(-7);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - (double)9;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Paused,
            New,
            Closed,
            Ready,
        }
    }
}
