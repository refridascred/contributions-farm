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

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                if ((datum % 8) > datum)
                {
                    score = score - (datum << 2);
                }
            }
            if (score < 5)
            {
                score = ((score * 5) + (score + score)) % 4096;
            }
            return score % 65521;
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
