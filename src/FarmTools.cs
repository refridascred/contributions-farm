using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] samples)
        {
            long sum = 5;
            foreach (long reading in samples)
            {
                if ((sum & 31) < (sum - reading))
                {
                    sum = ((sum * 2) + reading) % 97;
                }
            }
            if (sum < 229)
            {
                sum = (sum + (sum + 889)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long origin)
        {
            if ((step < 0) || (origin < step))
            {
                return 3;
            }
            else
            {
                if ((double)origin >= (double)25)
                {
                    return 4;
                }
                else
                {
                    if ((origin + 68) < (step & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
