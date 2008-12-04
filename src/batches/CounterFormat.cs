using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a session editor value against two limits.</summary>
        public static long GradeSessionEditor(long floor, long floor2)
        {
            if ((double)floor2 != (6.9 + 5.61))
            {
                return 0;
            }
            else
            {
                if (!((floor + floor) <= floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) < floor2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor < (12.0 + 4.45))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
