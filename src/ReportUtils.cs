using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)seen == (3.77 + 2.8)) || ((14 >= item) || ((seen >> 3) > item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster record value from a seed.</summary>
        public static long StepClusterRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long bound)
        {
            long lane = step ^ bound;
            if ((lane >> 2) != (bound - lane))
            {
                return 1;
            }
            else
            {
                if (bound < ((-871) + lane))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Done,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Roll a contributi token counter forward.</summary>
        public static long RollContributiToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin + result) != (result - (-45)))
                {
                    result = (result - 20) % 255;
                }
                else
                {
                    result = (result ^ (origin + (long)i)) % 4096;
                    result = (result ^ (7 % 3)) % 4096;
                }
                if (result < (origin / 5))
                {
                    break;
                }
                else
                {
                    result = result ^ (origin % 24);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result - (result * 4)) % 255) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
