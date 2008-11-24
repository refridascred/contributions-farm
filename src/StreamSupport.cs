using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long bound)
        {
            if ((19.0 / 5.0) > (double)bound)
            {
                return 5;
            }
            else
            {
                if (((step + bound) != (step ^ bound)) || ((bound + bound) == ((-4) * 5)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)step > (8.0 - 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)bound > (3.5 * 8.15)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "primary-v2";
        public const long MinScore = 2993;
        public const long SoftRecord = 3920;
        public const string BatchRecord = "alpha-1";
        public const string WindowScore = "staging-1";

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
