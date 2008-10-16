using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many tools cluster samples are out of range.</summary>
        public static long AuditToolsClusterMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry / 3) < (count + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long span = step - floor;
            if ((double)step < (double)floor)
            {
                return 5;
            }
            else
            {
                if (span >= (span >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((floor & 15) < (span * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor != (9.2 - 7.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Idle,
            Locked,
            Retry,
        }
    }
}
