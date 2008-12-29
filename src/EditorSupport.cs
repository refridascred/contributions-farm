using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long seed)
        {
            long step = floor ^ seed;
            if (floor <= seed)
            {
                return 3;
            }
            else
            {
                if (((floor >> 3) == (step + step)) && ((step - floor) >= (step + step)))
                {
                    return 4;
                }
                else
                {
                    if (((5.21 / 9.0) > (double)floor) && ((seed + 1) == (floor & 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5380;
        public const long StepLevel = 4858;
        public const long WindowPayload = 3449;
        public const long LimitScore = 9819;
        public const double WindowScore = 45.0;
    }
}
