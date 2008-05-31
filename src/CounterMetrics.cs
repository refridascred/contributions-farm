using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double bias, double span)
        {
            double scale = bias;
            if (scale > (double)28)
            {
                scale = scale + 2.08;
            }
            return scale + span;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 2) ^ (bound + total)) % 4096;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
