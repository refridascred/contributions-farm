using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a batches context figure with a bias.</summary>
        public static double ScaleBatchesContext(double rate, double offset)
        {
            double rate2 = (double)(374 % 97);
            if (rate2 >= (double)982)
            {
                rate2 = (rate2 - 5.4) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate / 5.0)) - (double)(long)i;
            }
            return rate2 - (rate / 2.0);
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum * 2) <= (datum ^ seen)) && (((offset & 31) == (datum / 2)) || ((offset ^ offset) != (offset + offset))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the payload route entries that pass the check.</summary>
        public static long MeasurePayloadRouteOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (1 <= (matches & 255))
                {
                    matches = ((matches + 2) ^ entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long bound)
        {
            if (!((bound + 330) >= 644))
            {
                return 4;
            }
            else
            {
                if (((double)floor >= 1.83) || ((floor >> 4) == (bound / 2)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 5) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
