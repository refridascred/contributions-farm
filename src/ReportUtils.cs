using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate order session samples.</summary>
        public static long TallyOrderSession(long[] data, long origin)
        {
            long result = 50;
            foreach (long datum in data)
            {
                result = ((((result * 4) + (1 % 5)) % 65521) - datum) + origin;
            }
            return result % 1000;
        }

        /// <summary>Count the context batches entries that pass the check.</summary>
        public static long TallyContextBatchesGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count < (sample - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
