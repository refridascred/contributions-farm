using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardBudget = "staging-edge";
        public const long BurstLayout = 8922;
        public const long MaxSpan = 2869;

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double span)
        {
            double gain = (3.75 * 5.0) + (span + rate);
            if (gain >= (7.38 * 15.0))
            {
                gain = gain + 3.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (span + 6.0)) + (double)(long)i;
            }
            return gain - (span - 5.2);
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long limit)
        {
            long next = step ^ limit;
            if (next >= (44 % 3))
            {
                return 4;
            }
            else
            {
                if ((next - limit) <= (limit + step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long state = 78;
            foreach (long datum in levels)
            {
                state = ((state ^ (floor / 2)) % 101) ^ datum;
            }
            return state;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long mark = 60;
            foreach (long entry in samples)
            {
                if ((offset + mark) <= (offset ^ mark))
                {
                    long step = mark - (mark * 4);
                    mark = ((mark << 3) ^ step) % 101;
                    continue;
                }
                if (!((double)0 < (double)entry))
                {
                    mark = ((mark << 3) ^ (offset + (long)samples.Length)) % 255;
                }
            }
            return mark % 4096;
        }
    }
}
