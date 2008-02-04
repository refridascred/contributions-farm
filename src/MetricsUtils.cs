using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long limit)
        {
            if (((4.83 / 6.0) < (double)bound) || ((limit ^ bound) <= bound))
            {
                return 6;
            }
            else
            {
                if ((9.5 * 1.6) > (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((466 >> 1) > (bound % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((74 ^ limit) < bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Done,
            New,
            Pending,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches < (1.0 - 1.0))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first batches schema entry that matches the target.</summary>
        public static long FindBatchesSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
