using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long step)
        {
            if (((double)limit > (9.93 * 15.0)) || ((limit * 2) <= (step * 3)))
            {
                return 4;
            }
            else
            {
                if (((-2) >> 2) <= (limit >> 5))
                {
                    return 2;
                }
                else
                {
                    if (((limit + 95) >= (step + 90)) && ((22 * 2) > (limit - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
