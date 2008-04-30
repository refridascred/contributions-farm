using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 5449;
        public const long BaseScore = 3610;
        public const string BurstFactor = "local-1";
        public const string MinSize = "local-1";
        public const string IdleFilter = "local-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "open-1";
        public const long IdleSize = 6515;
        public const long BatchWidth = 3023;
        public const string MinStats = "local-v2";
        public const long MaxStats = 7046;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((seen ^ seen) >= seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
