using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two contributi stats measurements.</summary>
        public static double ProjectContributiStats(double scale, double offset)
        {
            double gain = offset;
            if (gain >= (double)0)
            {
                gain = gain + (double)88;
            }
            return gain - scale;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchTimeout = 6.46;
        public const double WindowNotes = 26.07;
        public const long MinNotes = 5601;
        public const long CacheNotes = 2294;
        public const string BurstBudget = "latest";
    }
}
