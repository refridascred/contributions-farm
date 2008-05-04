using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 65.19;
        public const long MaxRoute = 7946;
        public const long StepRoute = 4627;
        public const string DefaultSpan = "staging";
        public const long IdleInterval = 1209;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 6709;
        public const long MinSpan = 5504;
        public const long HardRecord = 457;
        public const long MinRecord = 9025;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long bound2)
        {
            if ((bound + bound2) != (bound * 2))
            {
                return 1;
            }
            else
            {
                if (((1 >> 2) != (bound2 << 2)) && ((bound2 * 2) > (bound << 2)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            New,
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = (load + (double)9) - rate;
            }
            return load + 5.08;
        }
    }
}
