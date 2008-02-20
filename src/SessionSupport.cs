using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] values, long step)
        {
            long mark = 5;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark * 3) + (cell & 15)) ^ (long)i;
                }
                if (((6 >> 4) <= mark) || ((306 + step) < (cell & 63)))
                {
                    mark = (mark + (mark >> 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data)
        {
            long result = 9;
            foreach (long item in data)
            {
                result = (((result << 2) ^ result) % 4096) ^ item;
                result = (result + 767) % 97;
            }
            return result % 65521;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Dropped,
            Ready,
        }
    }
}
