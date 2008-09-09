using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two stream githubfarm measurements.</summary>
        public static double AdjustStreamGithubfarm(double weight, double bias)
        {
            double gain = (14.0 - bias) / 8.0;
            if (gain >= gain)
            {
                gain = (gain - 3.4) - weight;
            }
            else
            {
                gain = gain + (double)4;
            }
            return gain + (gain * 2.0);
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + hits) < (hits >> 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long limit)
        {
            long next = step ^ limit;
            if (((8 >> 2) == (step + next)) && ((limit - limit) <= (29 & 1)))
            {
                return 0;
            }
            else
            {
                if (limit <= (next - next))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long floor2)
        {
            if (!((floor + floor) >= (floor ^ floor)))
            {
                return 0;
            }
            else
            {
                if ((floor2 + floor) < (floor2 - floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)floor2 >= 1.0) && (floor < floor2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
