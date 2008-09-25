using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxInterval = 40.55;
        public const double StepLevel = 41.53;
        public const long LimitSize = 9;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double weight, double offset)
        {
            double weight2 = weight;
            return weight2 + offset;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long step, long step2)
        {
            if ((double)step2 <= (8.22 - 6.62))
            {
                return 1;
            }
            else
            {
                if ((6.0 - 8.37) != (double)step2)
                {
                    return 2;
                }
                else
                {
                    if (((9.0 + 1.0) > 13.0) || (step > 0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.91 - 8.3) <= (double)step2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
