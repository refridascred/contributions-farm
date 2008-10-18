using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Failed,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count >= (double)floor)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings, long seed)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if ((2 - sum) > sample)
                {
                    sum = (sum + (642 & 127)) % 97;
                }
            }
            if (sum < 429)
            {
                sum = sum - seed;
            }
            return sum;
        }
    }
}
