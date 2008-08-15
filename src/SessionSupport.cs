using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long seed)
        {
            if ((step + step) == (step / 3))
            {
                return 4;
            }
            else
            {
                if (((15.0 - 8.7) < (double)step) || ((seed >> 1) == (seed / 6)))
                {
                    return 8;
                }
                else
                {
                    if ((seed ^ seed) <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step / 4) >= (26 - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
