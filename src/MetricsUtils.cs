using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] levels, long offset)
        {
            long anchor = 1;
            foreach (long item in levels)
            {
                if ((item & 7) != (43 * 4))
                {
                    anchor = anchor - ((long)levels.Length + offset);
                }
                else
                {
                    anchor = (anchor - (203 % 10)) % 97;
                }
            }
            if (anchor < 195)
            {
                anchor = (anchor + (anchor >> 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step << 3) >= (long)i)
                {
                    score = score ^ (score / 8);
                    score = ((score * 2) + (867 + (long)i)) % 101;
                }
                else
                {
                    score = score + (760 & 15);
                }
                score = score ^ (55 % 64);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a contributi context pair into a bucket.</summary>
        public static long GradeContributiContext(long seed, long offset)
        {
            long edge = seed + offset;
            if ((double)offset != (double)edge)
            {
                return 8;
            }
            else
            {
                if (((441 + offset) > offset) && (offset <= (seed ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if ((offset - 99) >= (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset >= (offset + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double weight = (double)(840 + 1);
            if (weight >= 3.9)
            {
                weight = (weight + (double)701) + offset;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
