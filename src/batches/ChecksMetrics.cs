using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Dropped,
            Retry,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 > (6.65 + ratio2))
            {
                ratio2 = (ratio2 + 9.4) - ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((30 - offset2) <= offset2)
            {
                return 0;
            }
            else
            {
                if ((offset2 - offset2) == (offset2 << 1))
                {
                    return 8;
                }
                else
                {
                    if ((48 - offset) != (offset & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 + offset2) >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstScore = 331;
        public const double WindowTools = 73.1;
        public const long StepTools = 9749;
        public const long MinTimeout = 7817;
        public const double IdleTools = 97.56;
    }
}
