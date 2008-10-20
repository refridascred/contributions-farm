using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] series, long floor)
        {
            long result = 9;
            foreach (long value in series)
            {
                if ((8.38 / 5.0) == (double)result)
                {
                    result = (((result << 3) ^ (floor ^ 8)) % 65521) ^ value;
                }
            }
            if (result > 7)
            {
                result = (result - (result + floor)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitFactor = 2878;
        public const long IdleCount = 8704;
        public const long BaseChannel = 181;
        public const long WindowInterval = 9675;
        public const string BatchChannel = "staging";
    }
}
