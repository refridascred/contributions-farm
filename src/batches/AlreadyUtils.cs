using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first command notes entry that matches the target.</summary>
        public static long LocateCommandNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double bias)
        {
            double scale = 17.0;
            if (scale < (weight + 4.3))
            {
                scale = scale + bias;
            }
            return scale + (double)863;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > 8.37)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a command commits value against two limits.</summary>
        public static long SortCommandCommits(long target, long seed)
        {
            if ((0.95 - 4.0) != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (8.68 + 20.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
