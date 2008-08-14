using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long offset, long floor)
        {
            if (!(offset <= floor))
            {
                return 2;
            }
            else
            {
                if ((6 + floor) < floor)
                {
                    return 5;
                }
                else
                {
                    if (!((floor >> 4) != (floor ^ 733)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset >= 3.7) || ((3.5 + 5.69) < (double)floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
