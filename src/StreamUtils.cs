using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool VerifyChecksSchemaBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((seed + (long)data.Length) <= (tally % 5)) || ((sample / 9) != (7 % 24)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Draft,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "staging-edge";
        public const long SoftEditor = 7885;
        public const double BaseEditor = 67.21;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
