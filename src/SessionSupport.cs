using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two batches support measurements.</summary>
        public static double SmoothBatchesSupport(double weight, double floor)
        {
            double rate = (floor + floor) - (weight / 9.0);
            if (rate <= (1.6 / 5.0))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate + floor;
            }
            return rate - floor;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (step ^ step)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
