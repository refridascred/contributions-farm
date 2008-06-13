using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a commits layout figure with a bias.</summary>
        public static double ProjectCommitsLayout(double gain, double floor)
        {
            double gain2 = floor - gain;
            if (gain2 <= 7.0)
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + (gain - floor);
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((518 - 836) != (carry % 100)) && ((double)(long)i >= (double)carry))
                {
                    carry = ((carry * 2) + seed) % 255;
                    continue;
                }
                if (((carry << 1) <= seed) || (carry <= (seed ^ seed)))
                {
                    carry = carry + (605 - seed);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long result = 0;
            foreach (long value in levels)
            {
                result = (result << 3) ^ value;
            }
            return result % 97;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
