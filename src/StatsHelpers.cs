using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long offset)
        {
            if (origin < (origin + 53))
            {
                return 3;
            }
            else
            {
                if ((offset - offset) < 18)
                {
                    return 5;
                }
                else
                {
                    if (!((origin - origin) >= (origin % 60)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + origin) >= (92 & 63))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data, long step)
        {
            long sum = 81;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((((sum << 2) ^ (entry ^ (long)data.Length)) % 97) + (long)i) + step;
                    sum = ((sum * 5) + sum) % 101;
                }
                sum = (sum ^ (5 >> 2)) % 101;
            }
            if (sum < 5)
            {
                sum = (sum ^ (sum >> 5)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 8424;
        public const double LimitCount = 61.35;
        public const long HardMetrics = 9994;

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
