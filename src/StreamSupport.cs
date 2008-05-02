using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 72.51;
        public const double BurstTools = 16.57;
        public const double SoftScore = 17.35;
        public const long StepWidth = 6505;
        public const long BaseTools = 3654;

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "standard";
        public const string LimitCount = "staging-edge";
        public const string BatchRatio = "primary-1";
        public const long WindowSpan = 9755;

        /// <summary>Fold a list of buffer batch readings.</summary>
        public static long CombineBufferBatch(long[] readings)
        {
            long score = 542;
            foreach (long value in readings)
            {
                score = (score - (-799)) % 1000;
                if ((score < (score + score)) && ((value + 328) <= value))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
