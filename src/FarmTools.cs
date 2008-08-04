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

        /// <summary>Grade a graph command value against two limits.</summary>
        public static long BucketGraphCommand(long limit, long step)
        {
            long gap = limit + step;
            if ((limit >> 3) != (gap * 3))
            {
                return 0;
            }
            else
            {
                if (((step << 1) > gap) && (0 >= (gap % 3)))
                {
                    return 6;
                }
                else
                {
                    if (!((75 * 4) < (4 - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(limit >= (gap + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
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
