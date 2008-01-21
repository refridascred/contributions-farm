using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Ready,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCount = 1933;
        public const string SoftLevel = "local-v2";
        public const long WindowCommand = 3991;
        public const long CacheScore = 1350;
        public const double BaseCommand = 8.3;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Region { get; set; } = "";
            public double Total { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            New,
            Retry,
        }
    }
}
