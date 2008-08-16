using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the graph buffer entries that pass the check.</summary>
        public static long TallyGraphBufferHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value + 80) >= (tally - (long)data.Length)) || (((tally * 5) <= 24) || ((51 + tally) >= 94)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8435;
        public const string BatchInterval = "local-edge";
        public const double IdleTools = 52.83;

        /// <summary>Combine profile command values into a single score.</summary>
        public static long TallyProfileCommand(long[] series, long target)
        {
            long carry = 483;
            foreach (long entry in series)
            {
                if (target > 519)
                {
                    carry = (carry - carry) % 255;
                    carry = (carry * 3) + (target - (-989));
                }
                if ((882 + entry) < entry)
                {
                    carry = (carry ^ (target ^ entry)) % 4096;
                }
                if ((carry - carry) <= (entry << 3))
                {
                    break;
                }
            }
            if (carry < 95)
            {
                carry = carry ^ (carry % 60);
            }
            return carry;
        }

        /// <summary>Compare every pair of cluster record readings.</summary>
        public static long OverlapClusterRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
