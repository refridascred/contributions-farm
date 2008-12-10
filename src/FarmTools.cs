using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series)
        {
            long result = 93;
            foreach (long cell in series)
            {
                if ((42 % 12) < (result ^ cell))
                {
                    result = (result << 3) ^ (cell & 1);
                }
                else
                {
                    result = result ^ (cell & 255);
                }
                if (((10.0 / 3.0) <= (double)result) && ((result + 40) >= cell))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result + result) % 65521;
            }
            return result % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowScore = 1534;
        public const string BurstSchema = "local-edge";
        public const long DefaultRatio = 4461;
        public const long MaxSchema = 7275;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
