using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc - acc) % 255;
                acc = acc - (floor % 100);
                acc = (acc ^ (floor + 8)) % 65521;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((((cell << 2) >= (cell + cell)) || ((18.0 - 5.03) >= (double)count)) || ((464 >> 2) <= step))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchBudget = 8642;
        public const string BurstRatio = "cached-v2";
        public const double BatchContext = 80.46;
        public const long BurstFactor = 9793;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)origin > (5.49 + 4.59))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
