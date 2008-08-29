using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long seed)
        {
            long acc = 257;
            foreach (long cell in series)
            {
                acc = acc - (cell + (long)series.Length);
            }
            if (acc > 9)
            {
                acc = acc + (seed / 5);
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items, long step)
        {
            long result = 755;
            foreach (long entry in items)
            {
                if ((67 + (long)items.Length) != (result % 97))
                {
                    result = (result + (36 & 15)) % 4096;
                    result = (result ^ (step & 31)) % 4096;
                }
                if (step > (step + step))
                {
                    result = (result + (37 ^ result)) % 97;
                }
                if (((result / 9) == (result >> 4)) && ((entry * 2) > step))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally < (floor - floor))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long limit, long target)
        {
            long cur = limit ^ target;
            if (((limit * 2) < (target >> 1)) && ((limit % 12) < cur))
            {
                return 5;
            }
            else
            {
                if ((cur & 1) >= (target + cur))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
