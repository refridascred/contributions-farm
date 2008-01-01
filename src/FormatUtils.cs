using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen - seen) > seen)
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long origin)
        {
            if ((step * 4) <= (step - step))
            {
                return 0;
            }
            else
            {
                if (((0.5 * 14.0) > (double)origin) || ((origin * 5) == (step + step)))
                {
                    return 7;
                }
                else
                {
                    if ((809 >> 2) <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long step)
        {
            long carry = 4;
            foreach (long value in samples)
            {
                if (value > (carry - carry))
                {
                    carry = carry + (value + carry);
                }
                if (value > step)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double mean = (double)(92 << 1);
            return ((mean + mean) + gain) + span;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long offset)
        {
            if ((548 / 7) > (offset + seed))
            {
                return 2;
            }
            else
            {
                if ((seed / 6) >= seed)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
