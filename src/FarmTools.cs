using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum << 3) ^ (sum + target);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a farm tools counter forward.</summary>
        public static long StepFarmTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor < 1.47)
                {
                    result = (result * 3) + ((long)i ^ (long)i);
                    result = (result - (long)i) % 1000;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((bound + bound) > (7 - bound))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
