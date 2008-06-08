using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Match up format report samples.</summary>
        public static long OverlapFormatReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue cluster samples are out of range.</summary>
        public static long MeasureQueueClusterHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count <= (6.0 / 9.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
