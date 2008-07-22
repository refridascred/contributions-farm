using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!(count > (floor / 9)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double offset)
        {
            double rate = (double)(24 - (-714));
            if (rate <= offset)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (bias * 7.3)) + (double)(long)i;
            }
            return rate + 4.46;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
