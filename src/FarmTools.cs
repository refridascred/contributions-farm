using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
