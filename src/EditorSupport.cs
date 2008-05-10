using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many already window samples are out of range.</summary>
        public static long TallyAlreadyWindowGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + value) < (value >> 5))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Look up the position of a editor filter sample.</summary>
        public static long LocateEditorFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
