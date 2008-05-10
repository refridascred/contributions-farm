using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings, long target)
        {
            long result = 94;
            foreach (long value in readings)
            {
                if ((target << 3) >= target)
                {
                    result = result + (target ^ target);
                }
                else
                {
                    result = (result - value) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            New,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Compare every pair of context route readings.</summary>
        public static long OverlapContextRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
