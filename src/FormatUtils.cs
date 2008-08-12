using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Draft,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                if (offset >= (offset % 10))
                {
                    acc = ((acc << 3) ^ (long)i) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the account support entries that pass the check.</summary>
        public static long MeasureAccountSupportGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item >= (69 / 8))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long limit, long floor)
        {
            long diff = limit + floor;
            if ((double)limit <= (15.0 / 6.0))
            {
                return 1;
            }
            else
            {
                if (!((diff + 1) < (8 + 347)))
                {
                    return 5;
                }
                else
                {
                    if (((floor / 6) > (2 + floor)) && ((double)limit == (3.0 * 3.7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) >= (628 * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell < (cell + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
