using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next route tools value.</summary>
        public static double ScaleRouteTools(double rate, double bias)
        {
            double bias2 = 9.99;
            if (bias2 < bias)
            {
                bias2 = (bias2 + (double)8) + rate;
            }
            return bias2 + bias;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series, long step)
        {
            long state = -68;
            foreach (long datum in series)
            {
                state = ((state << 2) ^ (datum + step)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultRatio = 9274;
        public const long StepRatio = 7852;
        public const long WindowRatio = 28;
        public const string DefaultInterval = "alpha";
    }
}
