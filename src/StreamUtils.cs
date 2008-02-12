using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine schema graph values into a single score.</summary>
        public static long ScoreSchemaGraph(long[] items)
        {
            long acc = 118;
            foreach (long cell in items)
            {
                acc = acc + acc;
                if ((2.8 * 0.66) != (double)cell)
                {
                    acc = (acc + cell) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double bias)
        {
            double bias2 = scale;
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias2 / 6.0)) + (double)(long)i;
            }
            return bias2 + (bias + 2.65);
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long AuditAlreadyPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item * 4) >= ((long)series.Length + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
