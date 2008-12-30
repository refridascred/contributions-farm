using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count account context pairs that satisfy a relation.</summary>
        public static long PairAccountContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double gain, double floor)
        {
            double gain2 = 7.03 + gain;
            if (gain2 < (floor / 4.0))
            {
                gain2 = gain2 - (floor * 9.5);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + gain;
        }
    }
}
