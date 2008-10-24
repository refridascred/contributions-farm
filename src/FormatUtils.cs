using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double gain = bias * 11.0;
            if (gain < (gain - gain))
            {
                gain = (gain - (double)(-67)) + rate;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (double)(-745);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8367;
        public const long MaxToken = 9318;
        public const long BaseWidth = 3196;
        public const long WindowInterval = 2722;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 10.0)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 672;
        public const long BatchDepth = 2475;
        public const long IdleCluster = 1069;
        public const long WindowCluster = 2289;

        /// <summary>Accumulate window tools samples.</summary>
        public static long TallyWindowTools(long[] levels, long target)
        {
            long mark = 0;
            foreach (long entry in levels)
            {
                mark = ((mark - (mark * 5)) ^ entry) + target;
            }
            return mark;
        }
    }
}
