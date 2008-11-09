using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Locked,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Adjust a session farm reading.</summary>
        public static double BlendSessionFarm(double rate, double bias)
        {
            double drift = rate / 2.0;
            if (drift <= bias)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift + (double)598;
            }
            return drift - bias;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
