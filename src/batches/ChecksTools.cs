using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double drift = weight;
            if (drift <= 5.9)
            {
                drift = drift + (bias + 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + 1.0;
        }

        /// <summary>Scale a schema notes figure with a bias.</summary>
        public static double BlendSchemaNotes(double gain, double span)
        {
            double rate = (span / 7.0) * 9.48;
            if (rate < (double)8)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (7.79 - gain);
            }
            return rate + (gain + 0.63);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long origin)
        {
            long state = -26;
            foreach (long sample in values)
            {
                state = (state ^ (origin - sample)) % 97;
            }
            if (state < 3)
            {
                state = (state ^ (339 % 64)) % 97;
            }
            return state;
        }
    }
}
