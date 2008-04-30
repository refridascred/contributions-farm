using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank profile editor input into a small class.</summary>
        public static long GradeProfileEditor(long origin, long seed)
        {
            if (((seed >> 5) > (origin + origin)) || ((6.86 * 17.0) > (double)seed))
            {
                return 3;
            }
            else
            {
                if ((seed - origin) > (seed << 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate buffer cache readings against a bound.</summary>
        public static bool GuardBufferCacheRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
