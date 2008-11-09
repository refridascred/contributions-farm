using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 976;
            foreach (long entry in readings)
            {
                if ((entry << 3) <= (entry + score))
                {
                    score = (score - (score << 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
