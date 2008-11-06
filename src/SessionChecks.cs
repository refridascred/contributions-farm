using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a tools batch value against two limits.</summary>
        public static long GradeToolsBatch(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if (4.0 <= (double)limit2)
            {
                return 0;
            }
            else
            {
                if ((-1) <= limit2)
                {
                    return 7;
                }
                else
                {
                    if ((((-2) >> 4) > limit2) && (limit2 < edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit2 > (limit + 142))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate payload layout readings against a bound.</summary>
        public static bool ValidatePayloadLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Active,
            New,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
