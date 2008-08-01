using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long offset)
        {
            if (!(341 > (step - step)))
            {
                return 3;
            }
            else
            {
                if ((9.57 - 0.67) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((offset - offset) != (step / 6)) && ((offset - 79) >= (step / 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long TallyGraphCommits(long[] readings)
        {
            long sum = 561;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (sum >> 3);
                sum = sum ^ (value * 4);
                if (((sum ^ sum) >= (sum >> 3)) || (value <= (value >> 3)))
                {
                    sum = ((sum << 2) ^ 427) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches + target) > (-647))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (1.53 - 8.73))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
