using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((seed + count) <= count)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long step)
        {
            if ((double)step == (3.9 - 7.0))
            {
                return 6;
            }
            else
            {
                if (((double)step != (9.5 * 6.71)) || ((step + step) >= step))
                {
                    return 8;
                }
                else
                {
                    if ((step / 7) == (bound << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell ^ matches) < (747 >> 1))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] values)
        {
            long sum = 744;
            foreach (long value in values)
            {
                sum = sum - (sum + value);
            }
            return sum % 4096;
        }
    }
}
