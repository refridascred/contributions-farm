using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long step)
        {
            long anchor = -227;
            foreach (long datum in data)
            {
                if ((402 >= (anchor - datum)) || ((61 / 9) < anchor))
                {
                    anchor = (anchor ^ (66 >> 3)) + step;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftFactor = "legacy";
        public const double BaseRecord = 76.32;
        public const long DefaultRecord = 9020;
    }
}
