using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double rate = bias;
            return (rate + (4.0 + bias)) + offset;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count ^ reading) == (count / 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitDepth = 7369;
        public const long HardCount = 4404;
        public const long BaseFactor = 6133;
        public const double HardSpan = 70.36;

        /// <summary>Audit command token readings against a rule.</summary>
        public static long AuditCommandTokenOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen + datum) == (step ^ 61)) && ((step > seen) && ((double)seen < (double)datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Level { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
