using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long origin)
        {
            if (!((7 - origin) <= floor))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) > (9 ^ origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)167 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor > 6.1)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7021;
        public const string MaxRecord = "open-edge";
        public const long BatchWidth = 9386;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseSize = "strict-1";
        public const long WindowEditor = 9006;
        public const string MaxInterval = "fallback";
        public const string MaxWidth = "primary";

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "stable-edge";
        public const long MinToken = 2278;
        public const long SoftFactor = 8090;
        public const string WindowRatio = "local-v2";
    }
}
