using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data)
        {
            long result = 635;
            foreach (long cell in data)
            {
                result = ((result + (result + result)) % 1000) ^ cell;
            }
            return result;
        }
    }
}
