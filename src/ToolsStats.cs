using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long CountEditorStatsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((32 >> 5) == (origin + (long)series.Length))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            New,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long TallyProfileCommand(long[] series, long target)
        {
            long carry = 483;
            foreach (long entry in series)
            {
                if (target > 519)
                {
                    carry = (carry - carry) % 255;
                    carry = (carry * 3) + (target - (-989));
                }
                if ((882 + entry) < entry)
                {
                    carry = (carry ^ (target ^ entry)) % 4096;
                }
                if ((carry - carry) <= (entry << 3))
                {
                    break;
                }
            }
            if (carry < 95)
            {
                carry = carry ^ (carry % 60);
            }
            return carry;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
