using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            if ((offset2 + offset2) == (offset2 - 82))
            {
                return 4;
            }
            else
            {
                if ((double)offset <= 6.58)
                {
                    return 1;
                }
                else
                {
                    if ((offset >= (offset + offset2)) || ((8.2 - 0.1) == (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset2 / 8) > (offset2 - 8)) || ((offset2 - offset) >= (0 + 855)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (step - result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples, long target)
        {
            long acc = 5;
            foreach (long cell in samples)
            {
                if ((target << 1) >= (7 ^ cell))
                {
                    acc = (acc << 3) ^ (cell - cell);
                }
            }
            if (acc > 813)
            {
                acc = (acc ^ (target + acc)) % 4096;
            }
            return acc % 97;
        }
    }
}
