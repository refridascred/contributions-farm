using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long total = 52;
            foreach (long datum in readings)
            {
                if (39 < total)
                {
                    total = total ^ datum;
                }
                if ((total + datum) >= total)
                {
                    total = ((total * 5) + (total & 1)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (total << 2);
                }
            }
            if (total < 136)
            {
                total = (total * 5) + (64 + total);
            }
            return total;
        }
    }
}
