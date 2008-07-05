using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long limit, long origin)
        {
            if (!((220 ^ limit) > (limit & 3)))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (14.0 * 4.3))
                {
                    return 8;
                }
                else
                {
                    if (limit < (limit - 133))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Adjust a session already reading.</summary>
        public static double ProjectSessionAlready(double bias, double bias2)
        {
            double ratio = (bias / 7.0) - 5.0;
            return (ratio - (double)37) + bias2;
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
