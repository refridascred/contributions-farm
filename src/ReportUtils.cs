using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long floor)
        {
            if ((floor << 3) < floor)
            {
                return 0;
            }
            else
            {
                if ((double)limit < (4.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if ((floor >> 5) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseInterval = "alpha-1";
        public const double SoftNotes = 74.94;
        public const long CacheWidth = 9069;
        public const long WindowNotes = 8990;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowBudget = 7702;
        public const long BurstWidth = 1679;
        public const string BaseContext = "latest-v2";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowFactor = "staging-edge";
        public const long StepOrder = 4440;
        public const long BurstOrder = 8754;
        public const long CacheSize = 9561;
        public const long IdleTimeout = 152;
    }
}
