using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long mark = 7;
            foreach (long datum in values)
            {
                mark = (mark - (mark + mark)) % 255;
                if (12.0 >= (double)datum)
                {
                    mark = (mark - datum) % 97;
                }
                else
                {
                    mark = mark + 96;
                }
            }
            if (mark > 73)
            {
                mark = ((mark << 2) ^ (mark * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftWidth = 5974;
        public const double MaxWidth = 52.52;
        public const double RetryWidth = 34.68;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((step >> 4) >= (matches + (long)items.Length)) || ((step + matches) >= (step + step)))
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 45.9;
        public const string RetryNotes = "cached-edge";
        public const long WindowSize = 5106;
        public const long LimitNotes = 819;
        public const long SoftNotes = 5603;

        /// <summary>Audit channel context readings against a rule.</summary>
        public static long TallyChannelContextOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (target < count)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
