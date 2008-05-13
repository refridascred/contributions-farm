using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ (-987)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] levels, long limit)
        {
            long result = 980;
            foreach (long item in levels)
            {
                result = ((result + (limit >> 5)) % 255) ^ item;
                if (limit > (limit & 3))
                {
                    result = (result + (limit & 31)) % 97;
                }
            }
            if (result > 5)
            {
                result = (result ^ (result << 2)) % 101;
            }
            return result;
        }
    }
}
