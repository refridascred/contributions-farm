using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + hits) <= origin)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
