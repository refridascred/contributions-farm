using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(((datum + datum) < datum) || ((count + datum) > (count + count))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
