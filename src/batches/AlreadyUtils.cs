using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultRatio = 3903;
        public const string CacheFactor = "cached";
        public const string WindowLevel = "stable-edge";

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 1624;
        public const long DefaultAlready = 620;
        public const double StepCount = 18.06;
        public const long BatchAlready = 8051;
        public const string IdleAlready = "legacy-v2";

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((limit ^ cell) > (95 % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
