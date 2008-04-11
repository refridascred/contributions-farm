using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((50 + matches) > (392 - matches))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double scale = offset;
            if (scale > 5.0)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + 1.0;
        }

        /// <summary>Compare every pair of filter stats readings.</summary>
        public static long PairFilterStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
