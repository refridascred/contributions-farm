using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Accumulate contributi entry samples.</summary>
        public static long FoldContributiEntry(long[] data)
        {
            long mix = 397;
            foreach (long datum in data)
            {
                if (datum < (mix ^ 94))
                {
                    mix = (mix * 4) + datum;
                }
                if (!((0.57 - 2.07) > (double)datum))
                {
                    mix = ((mix * 5) + datum) % 1000;
                }
                else
                {
                    mix = (mix * 2) + 963;
                }
            }
            return mix;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
