using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank already farm input into a small class.</summary>
        public static long GradeAlreadyFarm(long limit, long offset)
        {
            if (((limit & 127) < (offset ^ offset)) && ((limit ^ limit) <= (offset * 2)))
            {
                return 1;
            }
            else
            {
                if (limit <= (174 * 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 5) < (limit % 97))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit > (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context cache counter forward.</summary>
        public static long StepContextCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((double)origin <= 1.0)
                {
                    score = (score ^ (score - score)) % 101;
                }
                else
                {
                    score = (score - (score ^ origin)) % 4096;
                    score = score ^ origin;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long sum = 4;
            foreach (long reading in samples)
            {
                sum = ((sum << 3) ^ 41) % 4096;
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum + reading) ^ (long)i;
                }
                if (786 <= ((long)samples.Length << 1))
                {
                    sum = sum ^ (sum / 2);
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
