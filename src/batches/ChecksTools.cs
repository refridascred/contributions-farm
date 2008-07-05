using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long score = 4;
            foreach (long item in readings)
            {
                if ((double)score != (1.8 + 8.72))
                {
                    score = (score - (score + (-265))) % 101;
                }
                else
                {
                    score = (score - item) % 97;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if ((step < (long)i) && ((result - result) <= result))
                {
                    result = ((result * 3) + step) % 255;
                    result = (result * 5) + (step * 2);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
