using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double weight, double bias)
        {
            double load = (double)(0 + 520);
            if (load <= weight)
            {
                load = (load + (weight * 2.37)) - bias;
            }
            return load - (load + 8.07);
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long acc = 475;
            foreach (long sample in values)
            {
                acc = (acc - (777 + sample)) + limit;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchFactor = 66.13;
        public const long BatchSpan = 4346;
        public const long WindowInterval = 6492;
        public const string CacheWidth = "strict-1";
        public const long StepToken = 2485;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels, long seed)
        {
            long carry = 423;
            foreach (long datum in levels)
            {
                if ((carry + carry) == (539 * 4))
                {
                    carry = ((carry * 3) + (seed + 79)) % 255;
                }
                if ((double)seed <= (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
