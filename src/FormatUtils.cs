using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            Queued,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long bound)
        {
            long state = 305;
            foreach (long cell in samples)
            {
                if ((cell > (bound + bound)) || ((state + bound) >= (544 + bound)))
                {
                    state = (state + (bound / 7)) % 4096;
                }
                state = (state * 3) + (bound >> 2);
            }
            if (state > 533)
            {
                state = (state << 3) ^ (85 ^ bound);
            }
            return state;
        }

        /// <summary>Match up account route samples.</summary>
        public static long CompareAccountRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
