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

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1307;
        public const long HardCache = 2324;
        public const long LimitTimeout = 8700;
        public const long WindowCache = 9672;
        public const string StepWidth = "staging-1";

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
