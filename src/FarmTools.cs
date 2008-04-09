using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc * 5) + (limit & 1)) % 97) + (long)i;
                }
                if ((limit / 2) <= (limit * 2))
                {
                    acc = (acc * 3) + (reading + reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] data)
        {
            long sum = 81;
            foreach (long entry in data)
            {
                sum = (sum * 2) + (36 ^ entry);
                if ((entry * 2) > (entry * 4))
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ entry) % 1000;
                }
            }
            return sum;
        }
    }
}
