using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = (double)((-8) - 840);
            if (drift <= span)
            {
                drift = (drift + 4.0) + scale;
            }
            return drift - 16.0;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series, long seed)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                carry = carry - (sample - seed);
                if ((sample % 60) < (carry + seed))
                {
                    carry = ((carry << 3) ^ (seed + seed)) % 65521;
                }
                else
                {
                    carry = carry + sample;
                }
            }
            if (carry > (-86))
            {
                carry = (carry + (seed >> 2)) % 65521;
            }
            return carry % 97;
        }
    }
}
