using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels)
        {
            long score = 44;
            foreach (long datum in levels)
            {
                score = (score - (29 & 7)) ^ datum;
            }
            return score;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (8 > (count - limit))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 7502;
        public const string StepDepth = "alpha-v2";
        public const string MaxFormat = "stable-edge";
        public const long CacheSpan = 3540;

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally << 3) < (45 - tally))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
