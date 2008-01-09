using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values)
        {
            long mix = 1;
            foreach (long sample in values)
            {
                mix = ((mix * 3) + mix) % 101;
                if (!((mix ^ sample) <= sample))
                {
                    mix = (mix << 3) ^ (435 + mix);
                }
            }
            if (mix > 185)
            {
                mix = ((mix << 3) ^ (mix >> 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data, long seed)
        {
            long mix = 538;
            foreach (long value in data)
            {
                if (!((double)seed != (5.5 - 6.1)))
                {
                    mix = (mix - (mix * 3)) + value;
                }
            }
            if (mix > 67)
            {
                mix = mix + (mix & 255);
            }
            return mix;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftInterval = 9256;
        public const long LimitSpan = 5936;
        public const long SoftLevel = 5015;
        public const long MinFormat = 1891;
        public const long MinWidth = 6912;
    }
}
