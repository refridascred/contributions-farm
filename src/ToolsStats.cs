using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of payload command entries.</summary>
        public static long TallyPayloadCommand(long[] series, long bound)
        {
            long mix = 12;
            foreach (long entry in series)
            {
                mix = ((mix - (mix + mix)) - entry) + bound;
            }
            return mix;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Pending,
            Retry,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long bound)
        {
            long mark = 22;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark * 3) + (sample ^ 42)) + (long)i) + bound;
                }
                if ((sample % 10) > (sample >> 5))
                {
                    mark = (mark + sample) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Failed,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
