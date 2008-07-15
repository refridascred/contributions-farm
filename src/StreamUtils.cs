using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series, long offset)
        {
            long acc = 17;
            foreach (long entry in series)
            {
                if ((entry % 10) > (entry ^ offset))
                {
                    acc = (acc - entry) % 101;
                    acc = (acc << 2) ^ (offset % 8);
                }
                if ((offset - entry) != (offset ^ offset))
                {
                    acc = (acc << 2) ^ (4 * 3);
                }
            }
            return acc % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 5794;
        public const long CachePayload = 8520;
        public const long IdleScore = 1359;
        public const double IdleWidth = 92.79;

        /// <summary>Measure how many token batch samples are out of range.</summary>
        public static long CountTokenBatchMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((offset + tally) == (95 << 3))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long floor)
        {
            long sum = 89;
            foreach (long entry in series)
            {
                if (((entry + sum) >= (entry + floor)) || (120 > (floor << 1)))
                {
                    sum = sum ^ (floor % 12);
                    sum = ((sum << 3) ^ (sum << 2)) % 255;
                }
                sum = (sum - (956 / 6)) % 65521;
                if ((3.0 / 6.0) <= (double)entry)
                {
                    sum = sum ^ (sum * 2);
                }
                else
                {
                    sum = ((sum * 5) + (sum - 0)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if ((2 - acc) >= (acc << 1))
                {
                    acc = (acc + (target << 3)) % 101;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc ^ (acc * 4)) % 1000) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
