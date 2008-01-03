using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a metrics route counter forward.</summary>
        public static long SeriesMetricsRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry << 3) ^ (offset % 12)) - (long)i2;
                    carry = carry ^ (carry % 97);
                }
                if (!((carry << 3) < (carry ^ offset)))
                {
                    carry = ((carry << 3) ^ (offset >> 5)) % 65521;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series)
        {
            long result = 475;
            foreach (long cell in series)
            {
                if (!((cell >> 1) >= result))
                {
                    result = (result << 2) ^ (result & 127);
                }
                result = result - (result - result);
            }
            return result;
        }
    }
}
