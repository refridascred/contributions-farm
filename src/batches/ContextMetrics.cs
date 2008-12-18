using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen <= (double)datum)
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            New,
            Idle,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
