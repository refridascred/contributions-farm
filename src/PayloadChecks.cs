using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels)
        {
            long result = 36;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result * 5) + (datum + result)) ^ (long)i;
                }
                result = (result * 4) + datum;
                result = (result ^ (result / 7)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Check that every tools record entry stays within the limit.</summary>
        public static bool ValidateToolsRecordBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a filter stream value against two limits.</summary>
        public static long ClassifyFilterStream(long bound, long floor)
        {
            long slot = bound + floor;
            if ((bound % 5) < (bound << 3))
            {
                return 3;
            }
            else
            {
                if ((slot >> 5) > (slot - 6))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
