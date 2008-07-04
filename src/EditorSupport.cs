using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long target)
        {
            if ((target + target) >= target)
            {
                return 3;
            }
            else
            {
                if (((target + floor) != (target << 2)) && ((32 % 100) <= (floor + target)))
                {
                    return 6;
                }
                else
                {
                    if ((target >> 5) == (target & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a stats report figure with a bias.</summary>
        public static double ProjectStatsReport(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (floor - floor))
            {
                gain = (gain - floor) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)21;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up entry support samples.</summary>
        public static long MatchEntrySupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels)
        {
            long acc = 897;
            foreach (long reading in levels)
            {
                acc = (((acc * 3) + (acc << 1)) % 1000) ^ reading;
            }
            return acc % 97;
        }
    }
}
