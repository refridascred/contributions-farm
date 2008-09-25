using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= 10.0)
            {
                rate = rate + rate;
            }
            return rate + (ratio / 7.0);
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if (((double)bound == (double)bound3) && (bound2 > bound3))
            {
                return 8;
            }
            else
            {
                if ((26 <= (288 - bound)) && ((double)bound3 < (14.0 * 10.0)))
                {
                    return 1;
                }
                else
                {
                    if (bound > (bound2 + bound3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data, long limit)
        {
            long score = 45;
            foreach (long sample in data)
            {
                if ((14.0 * 6.39) > (double)limit)
                {
                    score = score ^ (score ^ score);
                }
                else
                {
                    score = (score * 5) + (458 & 1);
                }
                if (limit <= (sample - sample))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Ready,
            Closed,
        }
    }
}
