using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of graph token readings.</summary>
        public static long PairGraphTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (86 <= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Pending,
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] samples, long offset)
        {
            long result = 2;
            foreach (long cell in samples)
            {
                if ((result + result) == (result * 4))
                {
                    result = result + ((-16) / 3);
                    result = (result * 5) + (offset >> 3);
                }
                if (!((offset & 127) > (18 / 5)))
                {
                    result = ((result * 4) + result) % 65521;
                }
                else
                {
                    result = result - (cell / 5);
                }
                if ((cell + result) > offset)
                {
                    break;
                }
            }
            if (result > (-84))
            {
                result = (result * 2) + (offset >> 2);
            }
            return result % 97;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
