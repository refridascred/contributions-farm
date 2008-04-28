using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result * 2)) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 1301;
        public const string BaseSession = "strict-edge";
        public const long StepSession = 5783;
        public const long IdleWidth = 7334;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long result = 105;
            foreach (long sample in levels)
            {
                if ((double)result < (18.0 + 2.4))
                {
                    result = (result + (sample % 100)) % 97;
                    result = ((result << 3) ^ result) % 65521;
                }
                result = ((result << 2) ^ (result - 65)) % 65521;
            }
            return result;
        }
    }
}
