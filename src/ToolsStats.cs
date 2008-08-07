using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long target, long step)
        {
            long lane = target + step;
            if ((66 + lane) == (target ^ 996))
            {
                return 2;
            }
            else
            {
                if ((step - lane) == ((-53) * 5))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels, long target)
        {
            long state = -2;
            foreach (long datum in levels)
            {
                state = ((state * 3) + datum) + target;
                state = (state + state) % 255;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 36.11;
        public const long MinScore = 3075;
        public const long MaxSize = 1989;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a context cluster reading by value.</summary>
        public static long SeekContextClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
