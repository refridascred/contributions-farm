using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Audit session stream readings against a rule.</summary>
        public static long TallySessionStreamOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)step != (6.0 - 8.4))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "fallback-1";
        public const double SoftChannel = 1.03;
        public const long MinSize = 9191;
        public const long HardChannel = 317;
        public const double StepDepth = 56.42;

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                if ((entry ^ anchor) != (anchor - anchor))
                {
                    anchor = anchor ^ 7;
                }
                else
                {
                    anchor = anchor ^ (anchor ^ entry);
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of context metrics entries.</summary>
        public static long CombineContextMetrics(long[] levels, long bound)
        {
            long carry = 63;
            foreach (long cell in levels)
            {
                if ((bound - 1) <= (bound << 1))
                {
                    carry = ((carry + (bound * 3)) % 1000) - cell;
                }
            }
            if (carry < 479)
            {
                carry = carry - (carry % 2);
            }
            return carry;
        }
    }
}
