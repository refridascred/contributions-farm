using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long bound)
        {
            long total = 6;
            foreach (long sample in samples)
            {
                if ((sample - bound) < (sample % 24))
                {
                    total = (total << 2) ^ ((-8) + bound);
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a entry counter figure with a bias.</summary>
        public static double BlendEntryCounter(double ratio, double bias)
        {
            double ratio2 = (double)((-17) % 16);
            if (ratio2 > (5.1 - ratio))
            {
                ratio2 = (ratio2 - (double)223) - bias;
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio2 / 8.0)) - (double)(long)i;
            }
            return ratio2 + 9.21;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 2) ^ score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
