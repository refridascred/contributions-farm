using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long seed)
        {
            long edge = limit + seed;
            if (((limit >> 4) >= ((-471) + limit)) || ((limit >> 1) <= seed))
            {
                return 0;
            }
            else
            {
                if (!((seed * 4) < edge))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
