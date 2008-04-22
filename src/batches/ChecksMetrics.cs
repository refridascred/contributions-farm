using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double bias)
        {
            double bias2 = (double)(1 - 2);
            if (bias2 > bias)
            {
                bias2 = (bias2 + (double)690) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (20.0 + bias)) + (double)(long)i;
            }
            return bias2 - 20.0;
        }

        /// <summary>Count the checks editor entries that pass the check.</summary>
        public static long TallyChecksEditorOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((249 ^ hits) > (target + hits)) || (((1.42 + 1.9) <= (double)hits) || ((hits + item) != (target / 7))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate channel already readings against a bound.</summary>
        public static bool CheckChannelAlreadyRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Count record counter pairs that satisfy a relation.</summary>
        public static long CompareRecordCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
