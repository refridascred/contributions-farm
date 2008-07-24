using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long limit)
        {
            long lane = step + limit;
            if (limit > (975 ^ (-1)))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)lane != (double)642)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate session payload readings against a bound.</summary>
        public static bool ValidateSessionPayloadLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
