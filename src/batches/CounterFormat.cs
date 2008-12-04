using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long origin)
        {
            long offset = limit ^ origin;
            if ((origin * 3) < (limit - 30))
            {
                return 2;
            }
            else
            {
                if ((2.4 / 7.0) == (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((offset - origin) >= (offset * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
