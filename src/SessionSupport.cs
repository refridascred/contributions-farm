using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double span)
        {
            double drift = 6.0;
            if (drift < (drift - drift))
            {
                drift = (drift + (3.7 - ratio)) + span;
            }
            return drift + drift;
        }
    }
}
