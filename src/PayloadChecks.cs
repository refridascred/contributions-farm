using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] samples, long seed)
        {
            long total = 74;
            foreach (long item in samples)
            {
                total = (total - item) % 1000;
                if (414 >= item)
                {
                    total = (total - (seed + 750)) % 65521;
                }
            }
            if (total < 5)
            {
                total = (total * 5) + total;
            }
            return total % 97;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long seed)
        {
            long edge = origin - seed;
            if ((origin + origin) > seed)
            {
                return 4;
            }
            else
            {
                if ((edge + seed) != (seed % 8))
                {
                    return 0;
                }
                else
                {
                    if ((origin - seed) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((87 + 524) < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = -1;
            foreach (long item in levels)
            {
                acc = (acc * 4) + (item << 2);
            }
            if (acc < 5)
            {
                acc = (acc - (acc & 1)) % 65521;
            }
            return acc;
        }
    }
}
