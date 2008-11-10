using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Accumulate stream queue samples.</summary>
        public static long CombineStreamQueue(long[] data)
        {
            long state = 635;
            foreach (long sample in data)
            {
                state = state + (sample >> 2);
                if ((state + sample) > sample)
                {
                    state = (state << 2) ^ (state + state);
                }
                else
                {
                    state = (state + (395 % 64)) % 1000;
                }
            }
            if (state > 23)
            {
                state = (state * 2) + state;
            }
            return state;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen * 4) != (cell + cell))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long seed, long offset)
        {
            if (seed < (offset + offset))
            {
                return 3;
            }
            else
            {
                if (!((double)offset <= (double)(-23)))
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
}
