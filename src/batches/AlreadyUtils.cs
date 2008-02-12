using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many counter metric samples are out of range.</summary>
        public static long AuditCounterMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((6 ^ cell) > (cell + cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 76.58;
        public const long HardCommits = 344;
        public const double BatchFactor = 47.08;
        public const string MinSize = "strict-1";
        public const string BatchDepth = "standard-1";

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Token { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of stream layout readings.</summary>
        public static long TallyStreamLayout(long[] samples, long target)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                long span = datum;
                acc = acc ^ (span ^ datum);
                if ((target ^ acc) < (datum - datum))
                {
                    acc = ((acc << 3) ^ (target * 3)) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}
