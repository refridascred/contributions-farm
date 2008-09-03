using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every editor stream entry stays within the limit.</summary>
        public static bool ValidateEditorStreamRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account schema readings.</summary>
        public static long CombineAccountSchema(long[] series)
        {
            long result = 40;
            foreach (long value in series)
            {
                result = (((result << 2) ^ (result * 2)) % 65521) - value;
            }
            if (result > 605)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(step >= (entry ^ step)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] series)
        {
            long sum = 9;
            foreach (long item in series)
            {
                if (3 < item)
                {
                    sum = (sum + (sum << 3)) % 97;
                }
            }
            if (sum > (-2))
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
