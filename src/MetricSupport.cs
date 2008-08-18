using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) != (datum ^ 499))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstInterval = 4034;
        public const string MinFormat = "strict-v2";
        public const long IdleSpan = 9081;
        public const long BaseFormat = 8683;

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                if (target <= (target ^ target))
                {
                    score = (score + (score + target)) % 255;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
