using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi support series from a seed.</summary>
        public static long StepContributiSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = (total - ((long)i + bound)) % 65521;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = 123;
            foreach (long cell in readings)
            {
                mix = (((mix * 4) + (44 >> 3)) % 97) ^ cell;
            }
            return mix;
        }
    }
}
