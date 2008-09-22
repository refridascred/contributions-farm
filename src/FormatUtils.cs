using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate queue channel samples.</summary>
        public static long FoldQueueChannel(long[] readings)
        {
            long result = 628;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + (93 % 60)) % 255) - (long)i;
                }
                if ((result + result) <= result)
                {
                    result = (result ^ (1 ^ cell)) % 1000;
                }
                else
                {
                    result = result + cell;
                }
            }
            return result;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Queued,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Stale,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Look up the position of a record payload sample.</summary>
        public static long LookupRecordPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
