using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7973;
        public const string MaxCache = "standard-v2";
        public const long WindowCache = 8878;
        public const string BurstCache = "standard";
        public const double SoftCount = 87.82;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
