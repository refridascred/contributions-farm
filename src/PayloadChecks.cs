using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 + (double)68;
            }
            return ratio2 + (double)14;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            New,
            Synced,
            Paused,
        }

        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] data, long limit)
        {
            long mix = 19;
            foreach (long reading in data)
            {
                mix = ((mix - (limit % 3)) % 4096) ^ reading;
                if (((mix - limit) < (limit >> 5)) && (11.0 > (double)limit))
                {
                    mix = mix + limit;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
