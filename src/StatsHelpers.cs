using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a window channel reading by value.</summary>
        public static long SeekWindowChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel githubfarm readings against a rule.</summary>
        public static long MeasureChannelGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) <= ((-7) + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)31 > (double)total))
                {
                    total = ((total << 2) ^ ((long)i + bound)) % 65521;
                    total = (total ^ (bound ^ total)) % 255;
                }
                else
                {
                    total = (total - (total * 5)) % 97;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public double Limit { get; set; }
        }
    }
}
