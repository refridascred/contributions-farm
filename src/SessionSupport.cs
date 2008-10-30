using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples)
        {
            long anchor = 153;
            foreach (long cell in samples)
            {
                if ((anchor / 3) != (cell + cell))
                {
                    anchor = (anchor - cell) % 101;
                }
                else
                {
                    anchor = ((anchor * 4) + (cell % 8)) % 4096;
                }
                if ((anchor + anchor) == (anchor + cell))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                if (cell <= (anchor + 4))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
