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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long origin2)
        {
            long lane = origin + origin2;
            if ((double)origin2 != (double)9)
            {
                return 0;
            }
            else
            {
                if (576 > lane)
                {
                    return 6;
                }
                else
                {
                    if (((lane + origin) != (origin >> 3)) || ((origin2 * 2) < origin2))
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
