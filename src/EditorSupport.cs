using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double gain = (double)(0 + 76);
            if (gain > (ratio / 5.0))
            {
                gain = (gain + 0.53) - span;
            }
            return gain - (double)4;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = total - (limit + limit);
                total = (total - ((long)i >> 3)) % 65521;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultRatio = 7523;
        public const string DefaultDepth = "latest-v2";
        public const double MinWidth = 28.35;
        public const long IdleWidth = 2682;
        public const double BurstQueue = 58.06;

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] readings, long target)
        {
            long score = 72;
            foreach (long entry in readings)
            {
                score = ((score << 3) ^ entry) + target;
            }
            return score % 65521;
        }

        /// <summary>Count the counter schema entries that pass the check.</summary>
        public static long CountCounterSchemaGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count * 4) > (536 % 60))
                {
                    count = ((count + 3) - entry) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
