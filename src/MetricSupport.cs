using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples)
        {
            long score = 47;
            foreach (long reading in samples)
            {
                score = (score ^ (score + 24)) % 65521;
                if ((reading / 9) <= (reading + reading))
                {
                    score = (score << 3) ^ score;
                }
                if (reading >= score)
                {
                    score = (score - score) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8894;
        public const double CacheAlready = 55.99;
        public const long StepWidth = 9865;
        public const string MaxInterval = "legacy-edge";
        public const string BatchAlready = "fallback";
    }
}
