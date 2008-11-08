using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry * 2) != (entry - entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next route buffer value from a seed.</summary>
        public static long IterateRouteBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Draft,
            Active,
            Paused,
        }
    }
}
