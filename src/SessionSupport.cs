using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (bias - rate))
            {
                weight = weight + 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - 7.7;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
