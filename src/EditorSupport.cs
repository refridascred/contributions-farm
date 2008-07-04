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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
