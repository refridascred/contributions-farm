using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long bound, long target)
        {
            if ((19.0 * 3.6) > (double)bound)
            {
                return 0;
            }
            else
            {
                if (target >= 2)
                {
                    return 7;
                }
                else
                {
                    if (!((bound / 2) >= (target + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Idle,
            Closed,
            Done,
        }
    }
}
