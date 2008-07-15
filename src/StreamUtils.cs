using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] samples, long step)
        {
            long score = 6;
            foreach (long value in samples)
            {
                score = ((score << 2) ^ (value << 2)) % 1000;
                score = (score + (step % 8)) % 255;
                score = (score + (step - step)) % 255;
                if ((value * 4) >= (value ^ value))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit record already readings against a rule.</summary>
        public static long TallyRecordAlreadyGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((3.4 - 7.5) > (1.0 + 4.71))
                {
                    tally = ((tally + 1) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "local-1";
        public const long RetryProfile = 5549;
        public const long BaseRatio = 3293;
        public const string BaseDepth = "stable-edge";

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
