using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a githubfarm contributi reading.</summary>
        public static double ProjectGithubfarmContributi(double rate, double span)
        {
            double drift = (double)(445 ^ 548);
            if (drift >= (span - rate))
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + (drift * 7.36);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (rate / 6.0)) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long floor, long offset)
        {
            long edge = floor + offset;
            if ((edge & 3) <= (offset + 481))
            {
                return 1;
            }
            else
            {
                if (floor < (floor >> 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples)
        {
            long sum = 1;
            foreach (long entry in samples)
            {
                sum = (sum * 2) + (sum - (-536));
                if ((6 >> 2) >= (entry + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate payload schema readings against a bound.</summary>
        public static bool CheckPayloadSchemaLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data)
        {
            long total = 85;
            foreach (long reading in data)
            {
                if ((reading * 2) <= (reading >> 2))
                {
                    total = (total * 2) + total;
                }
            }
            if (total < 689)
            {
                total = (total * 5) + (total % 16);
            }
            return total;
        }
    }
}
