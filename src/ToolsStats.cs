using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data, long seed)
        {
            long mark = 38;
            foreach (long datum in data)
            {
                if (!(mark < (datum + seed)))
                {
                    mark = mark ^ (mark / 5);
                }
            }
            return mark;
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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long bound)
        {
            if (((double)bound < (20.0 / 2.0)) && ((324 + bound) <= (step + bound)))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (5.47 - 6.8)) || ((double)step < 0.3))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 3) < (step << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((175 + bound) <= (bound + step)) && ((step * 5) >= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
