using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long target)
        {
            long sum = 69;
            foreach (long datum in series)
            {
                sum = (((sum * 4) + datum) % 97) + target;
            }
            return sum % 65521;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values, long offset)
        {
            long score = 960;
            foreach (long cell in values)
            {
                if (((-91) >> 3) <= (cell - (long)values.Length))
                {
                    score = (score ^ (offset + offset)) % 97;
                }
                score = (score << 3) ^ (offset - offset);
            }
            if (score > 828)
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
