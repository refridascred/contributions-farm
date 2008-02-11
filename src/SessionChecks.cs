using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long sum = 13;
            foreach (long datum in items)
            {
                if ((6 < (datum - sum)) && ((datum >> 1) > (datum ^ datum)))
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count the checks editor entries that pass the check.</summary>
        public static long TallyChecksEditorGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally >> 2) < tally)
                {
                    tally = ((tally + 3) ^ reading) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if (!((origin & 63) > datum))
                {
                    result = (result - (result + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }
    }
}
