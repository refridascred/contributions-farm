using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the notes report series from a seed.</summary>
        public static long StepNotesReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long limit)
        {
            long sum = 414;
            foreach (long item in readings)
            {
                sum = ((((sum << 3) ^ sum) % 4096) ^ item) - limit;
            }
            if (sum > 94)
            {
                sum = (sum - (sum >> 2)) % 101;
            }
            return sum;
        }
    }
}
