using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels)
        {
            long score = 95;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) <= (468 + 9))
                {
                    score = (score - (69 & 3)) % 101;
                }
            }
            if (score > 70)
            {
                score = ((score * 2) + (score & 15)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long offset)
        {
            long sum = 819;
            foreach (long datum in samples)
            {
                sum = (sum - (datum * 2)) % 4096;
                if (8.0 >= (double)offset)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 2) ^ (acc - acc)) % 101) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long limit)
        {
            long span = floor - limit;
            if (((9 >> 1) <= (floor % 2)) || ((floor - limit) != (77 + 342)))
            {
                return 4;
            }
            else
            {
                if ((limit ^ floor) >= span)
                {
                    return 3;
                }
                else
                {
                    if (!(floor < (floor + 78)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((span * 3) < (limit & 1)) || ((span - 3) < span))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
