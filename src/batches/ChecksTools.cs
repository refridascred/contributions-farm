using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long carry = -694;
            foreach (long cell in items)
            {
                if (!((double)carry >= (1.49 + 6.0)))
                {
                    carry = (carry ^ carry) - target;
                }
                if (cell >= (1 - carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long seed)
        {
            if ((bound + (-611)) > bound)
            {
                return 7;
            }
            else
            {
                if ((double)seed > (4.9 + 9.9))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (748 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the format stats series from a seed.</summary>
        public static long SeriesFormatStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((mark / 6) != (floor - mark)))
                {
                    mark = (mark + (long)i) % 4096;
                }
                if (!((11.0 * 3.0) >= (double)(long)i))
                {
                    mark = (mark ^ (floor + mark)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
