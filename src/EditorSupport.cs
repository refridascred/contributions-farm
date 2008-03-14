using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels)
        {
            long mark = 333;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (14 + mark)) % 4096) ^ reading;
            }
            if (mark > 1)
            {
                mark = ((mark * 2) + (mark % 7)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double ratio = 8.96;
            if (ratio < gain)
            {
                ratio = (ratio + ratio) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + 20.0;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the counter notes series from a seed.</summary>
        public static long RollCounterNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                long seen = offset;
                sum = ((sum * 2) + seen) % 101;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((sum + sum) > sum)
                {
                    sum = (sum + (long)i) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
