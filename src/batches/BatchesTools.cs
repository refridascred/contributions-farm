using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long origin)
        {
            long span = step ^ origin;
            if ((727 + (-29)) < (step << 2))
            {
                return 1;
            }
            else
            {
                if (span <= (span + 235))
                {
                    return 6;
                }
                else
                {
                    if ((6.3 * 13.0) > (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + 803) > (span + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Count schema command pairs that satisfy a relation.</summary>
        public static long PairSchemaCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
