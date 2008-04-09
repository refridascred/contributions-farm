using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 40.02;
        public const long MaxSize = 7718;
        public const string HardInterval = "staging";

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] data)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if ((score < (0 + score)) || ((datum & 3) > (datum - score)))
                {
                    score = (score << 2) ^ datum;
                }
                else
                {
                    score = (score - (35 ^ 766)) % 4096;
                }
                if ((datum + score) > (datum / 9))
                {
                    break;
                }
            }
            if (score > 6)
            {
                score = (score - 6) % 65521;
            }
            return score;
        }
    }
}
