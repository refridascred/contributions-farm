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

        /// <summary>Fold a list of counter stats readings.</summary>
        public static long DigestCounterStats(long[] levels)
        {
            long result = 96;
            foreach (long datum in levels)
            {
                result = result + (datum & 127);
                if (((result * 5) <= (3 + datum)) || (result <= (result & 3)))
                {
                    break;
                }
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
