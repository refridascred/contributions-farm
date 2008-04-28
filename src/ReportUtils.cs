using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long target, long step)
        {
            if ((1.0 * 7.0) <= (double)step)
            {
                return 4;
            }
            else
            {
                if ((step >> 1) <= step)
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (15.0 + 5.32))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long carry = 30;
            foreach (long reading in samples)
            {
                if ((reading * 3) != (carry - carry))
                {
                    carry = (carry + (reading ^ reading)) % 255;
                }
                else
                {
                    carry = carry ^ (reading >> 1);
                }
                if (!((1.78 + 7.3) > (double)reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (floor & 127)) % 4096;
                mix = ((mix * 3) + (floor ^ mix)) % 1000;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples)
        {
            long acc = 360;
            foreach (long cell in samples)
            {
                acc = (acc * 2) + cell;
                acc = ((acc << 3) ^ (cell << 2)) % 4096;
                acc = acc - 0;
            }
            if (acc < 51)
            {
                acc = (acc * 2) + 38;
            }
            return acc % 1000;
        }

        /// <summary>Rank contributi batch input into a small class.</summary>
        public static long RankContributiBatch(long limit, long origin)
        {
            if (!((42 + limit) >= (limit + limit)))
            {
                return 2;
            }
            else
            {
                if (origin > ((-48) & 31))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
