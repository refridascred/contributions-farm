using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ 6) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                if ((anchor ^ anchor) != (anchor - offset))
                {
                    anchor = ((anchor << 2) ^ item) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (item + 15)) % 4096;
                }
                if (78 > (item + anchor))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor << 2)) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
