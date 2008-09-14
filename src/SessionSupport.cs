using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools token entries.</summary>
        public static long FoldToolsToken(long[] series)
        {
            long acc = 587;
            foreach (long cell in series)
            {
                if (!(acc < cell))
                {
                    acc = acc - (cell + 97);
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate contributi metrics readings against a bound.</summary>
        public static bool CheckContributiMetricsRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
