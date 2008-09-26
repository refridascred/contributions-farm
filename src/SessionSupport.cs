using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!((5.0 / 9.0) >= (double)(long)i))
                {
                    mix = (mix * 4) + (floor / 6);
                }
                mix = ((mix << 2) ^ floor) % 4096;
                mix = (mix - ((long)i >> 3)) % 97;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long reading in readings)
            {
                if (!(1.1 >= 1.9))
                {
                    acc = (acc + (offset + (long)readings.Length)) + reading;
                }
            }
            if (acc < 898)
            {
                acc = ((acc << 2) ^ (offset + 476)) % 101;
            }
            return acc % 65521;
        }
    }
}
