using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long limit)
        {
            long gap = step - limit;
            if (!((7.0 - 9.88) != (double)gap))
            {
                return 1;
            }
            else
            {
                if (!((gap - gap) >= step))
                {
                    return 6;
                }
                else
                {
                    if (((double)step >= 1.81) || ((step - gap) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit tools route readings against a rule.</summary>
        public static long CountToolsRouteGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((matches * 5) <= matches) || (((limit * 2) < (limit << 2)) && ((double)matches >= 8.58)))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine editor tools values into a single score.</summary>
        public static long ScoreEditorTools(long[] items)
        {
            long anchor = 2;
            foreach (long entry in items)
            {
                anchor = anchor - (entry >> 3);
            }
            return anchor;
        }

        /// <summary>Check that every support counter entry stays within the limit.</summary>
        public static bool CheckSupportCounterLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a support farm sample.</summary>
        public static long FindSupportFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
