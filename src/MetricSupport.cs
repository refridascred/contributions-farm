using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long floor, long limit)
        {
            if ((limit << 2) == (floor & 63))
            {
                return 4;
            }
            else
            {
                if ((limit < floor) || (limit >= (limit << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((limit + 604) >= 594)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)limit <= (6.93 + 15.0)) || (9.17 <= (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
