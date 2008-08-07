using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first githubfarm editor entry that matches the target.</summary>
        public static long SeekGithubfarmEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheRatio = 57.61;
        public const string IdleFarm = "strict-1";
        public const long MinFarm = 5296;
        public const long WindowFarm = 799;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample >= ((long)samples.Length - tally)) || ((sample * 5) != (tally + sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
