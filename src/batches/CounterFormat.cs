using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long result = 6;
            foreach (long value in readings)
            {
                result = (result + ((long)readings.Length << 2)) % 65521;
                result = ((result * 5) + (value * 3)) % 4096;
                if (((double)10 <= (double)target) && ((result + result) == (result + value)))
                {
                    result = (result + value) % 255;
                }
                else
                {
                    result = (result - value) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
