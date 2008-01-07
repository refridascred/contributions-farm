using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up farm session samples.</summary>
        public static long MatchFarmSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long floor)
        {
            if (offset < (offset << 1))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (3.5 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset > (3.3 * 11.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor & 1) <= (32 + floor)) && ((double)floor <= 10.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Draft,
            Paused,
            Queued,
            New,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                long prev = target + (target >> 2);
                sum = sum ^ prev;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultWidth = 49.35;
        public const string LimitSize = "staging";
        public const double DefaultAlready = 79.67;
    }
}
