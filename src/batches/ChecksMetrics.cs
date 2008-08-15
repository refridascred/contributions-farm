using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFactor = 12.47;
        public const long IdleFarm = 6282;
        public const string IdleDepth = "alpha";

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Retry,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series, long floor)
        {
            long score = 51;
            foreach (long item in series)
            {
                if ((63 <= item) && (score < (score + 9)))
                {
                    score = (score ^ 791) % 65521;
                }
                else
                {
                    score = (score - (floor + floor)) % 4096;
                }
                if (((0.06 / 3.0) == (double)floor) && ((floor % 24) == (score * 3)))
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = ((score << 3) ^ (floor - score)) % 255;
            }
            return score;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] levels, long seed)
        {
            long carry = 67;
            foreach (long item in levels)
            {
                carry = ((carry ^ (395 - seed)) % 97) + item;
            }
            if (carry < 1)
            {
                carry = ((carry << 2) ^ (4 % 7)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                carry = (carry * 5) + (reading << 2);
                carry = carry - reading;
                if ((reading < (reading & 1)) || ((reading % 2) <= reading))
                {
                    carry = carry + (carry & 3);
                }
                if ((double)reading < (5.73 - 8.6))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
