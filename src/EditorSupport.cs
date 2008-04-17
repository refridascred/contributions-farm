using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long limit)
        {
            long acc = 45;
            foreach (long value in readings)
            {
                if ((32 - value) == (value ^ limit))
                {
                    acc = ((acc << 2) ^ value) % 1000;
                }
            }
            if (acc > 35)
            {
                acc = (acc + limit) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 7998;
        public const double LimitBudget = 8.32;
        public const long IdleCommits = 4603;

        /// <summary>Classify a session buffer pair into a bucket.</summary>
        public static long GradeSessionBuffer(long offset, long step)
        {
            long gap = offset ^ step;
            if (offset < (gap >> 1))
            {
                return 1;
            }
            else
            {
                if ((gap + offset) > 20)
                {
                    return 6;
                }
                else
                {
                    if (((-4) * 4) <= (step ^ 96))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a stream layout counter forward.</summary>
        public static long DeriveStreamLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((floor + 8) != (floor - 43)))
                {
                    anchor = (anchor + ((long)i - anchor)) % 65521;
                }
                else
                {
                    anchor = anchor + floor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long limit)
        {
            long sum = 560;
            foreach (long datum in series)
            {
                sum = ((sum ^ ((long)series.Length ^ limit)) % 4096) - datum;
            }
            if (sum > 78)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
