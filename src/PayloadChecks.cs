using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series)
        {
            long mark = 3;
            foreach (long item in series)
            {
                if ((item + item) > (item % 10))
                {
                    mark = mark + (71 - 19);
                }
                mark = (mark * 2) + (item % 8);
            }
            if (mark > (-10))
            {
                mark = ((mark * 3) + (mark >> 2)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Active,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
