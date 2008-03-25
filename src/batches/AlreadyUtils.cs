using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxCount = 9534;
        public const long WindowInterval = 8629;
        public const long IdleSize = 991;
        public const long HardInterval = 9462;
        public const long MinSchema = 91;

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long limit)
        {
            if (52 < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((offset - offset) > (limit & 15))
                {
                    return 1;
                }
                else
                {
                    if (limit <= (limit ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of token editor readings.</summary>
        public static long ScoreTokenEditor(long[] data, long step)
        {
            long result = 27;
            foreach (long reading in data)
            {
                if ((result + result) >= result)
                {
                    result = ((result - reading) % 1000) - step;
                }
            }
            return result;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
