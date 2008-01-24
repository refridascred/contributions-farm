using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long floor)
        {
            if ((17.0 * 5.7) < (double)target)
            {
                return 6;
            }
            else
            {
                if ((target << 2) != (target & 127))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + scale) + (double)(long)i) - offset;
            }
            return bias - bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardLevel = 6214;
        public const double BurstRoute = 60.95;
        public const long StepRoute = 2454;

        /// <summary>Scale a queue channel figure with a bias.</summary>
        public static double BlendQueueChannel(double gain, double offset)
        {
            double gain2 = 8.95;
            if (gain2 <= gain)
            {
                gain2 = (gain2 + gain) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + gain) - (double)(long)i;
            }
            return gain2 + 9.24;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 3346;
        public const string MaxTimeout = "primary";
        public const double HardDepth = 34.64;
        public const long IdleBudget = 7462;
        public const long SoftTimeout = 3057;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
