using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((value >= (value - value)) || ((-832) <= (value + value))))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry >> 1) > (tally << 2)) && (((tally ^ tally) > (tally >> 1)) || ((double)tally != (double)entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long state = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 346) > (datum & 255))
                {
                    break;
                }
                if ((8 < (state + 340)) && ((datum + (-298)) < 0))
                {
                    state = ((state << 2) ^ state) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                long step2 = step + mark;
                if (((step / 3) >= (step >> 1)) || ((double)step2 > (4.0 - 0.22)))
                {
                    break;
                }
                else
                {
                    step2 = (step2 - (mark >> 3)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double gain = (double)(26 & 1);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (bias - 3.8)) + (double)(long)i;
            }
            return gain + bias2;
        }
    }
}
