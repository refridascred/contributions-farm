using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift < (7.0 / 9.0))
            {
                drift = drift + (rate - rate);
            }
            return drift + floor;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
