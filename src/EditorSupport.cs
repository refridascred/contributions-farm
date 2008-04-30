using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            if (20 > bound)
            {
                return 1;
            }
            else
            {
                if (((offset << 2) == (offset / 7)) && ((0.4 + 8.9) == (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((offset % 97) != (bound + 234))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4 + bound) > 8)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + (step / 4)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((38 >= (count / 8)) && ((count & 31) > (sample & 15)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double bias = (scale + floor) + (double)79;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + 19.0) + (double)(long)i;
            }
            return bias + (floor * 9.88);
        }
    }
}
