using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine stream report values into a single score.</summary>
        public static long CombineStreamReport(long[] samples, long floor)
        {
            long result = -576;
            foreach (long datum in samples)
            {
                result = (result << 3) ^ (long)samples.Length;
                if (result <= (result & 255))
                {
                    result = (result - (datum >> 2)) % 1000;
                }
                else
                {
                    result = (result ^ (result / 8)) % 97;
                }
            }
            if (result < 877)
            {
                result = (result * 4) + floor;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
