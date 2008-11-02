using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a context counter sample.</summary>
        public static long SeekContextCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits metric samples.</summary>
        public static long OverlapCommitsMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((floor >> 5) < floor) || ((floor + (long)i) <= (score + (long)i)))
                {
                    score = score ^ 79;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading + count) >= (reading & 3)) || !((reading << 1) < (count << 2)))
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
    }
}
