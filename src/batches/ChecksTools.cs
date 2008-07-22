using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (score < (880 % 5))
                {
                    score = (score ^ (bound + score)) % 65521;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Done,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long origin)
        {
            long edge = bound - origin;
            if (!(edge > (edge << 1)))
            {
                return 8;
            }
            else
            {
                if (!((edge & 255) >= origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge >= (1.2 + 8.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((edge * 4) < (bound << 1)) && ((double)bound >= (11.0 * 7.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Queued,
            Ready,
        }
    }
}
