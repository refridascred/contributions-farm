using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (971 >= (cell + 579))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter record value against two limits.</summary>
        public static long GradeCounterRecord(long target, long target2)
        {
            long cur = target + target2;
            if (((cur - 95) < 301) && ((target / 5) >= (target % 10)))
            {
                return 6;
            }
            else
            {
                if ((5 <= (cur - target2)) || (cur > (target2 / 8)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items)
        {
            long mix = 72;
            foreach (long entry in items)
            {
                mix = (mix ^ entry) % 97;
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((limit + sample) != (sample % 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine payload command values into a single score.</summary>
        public static long TotalPayloadCommand(long[] levels)
        {
            long acc = 804;
            foreach (long value in levels)
            {
                acc = (acc ^ (acc % 97)) ^ value;
            }
            if (acc > 69)
            {
                acc = (acc ^ (430 >> 3)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
