using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items)
        {
            long sum = 587;
            foreach (long item in items)
            {
                if (!((item - sum) <= item))
                {
                    sum = ((sum << 3) ^ (sum ^ 38)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of cluster githubfarm entries.</summary>
        public static long CombineClusterGithubfarm(long[] items, long step)
        {
            long acc = 95;
            foreach (long value in items)
            {
                acc = ((acc + (203 ^ 5)) % 97) + value;
                acc = acc - (step ^ step);
                if ((64 - step) <= (step - (long)items.Length))
                {
                    break;
                }
            }
            if (acc < 998)
            {
                acc = (acc + (step << 2)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + 6) % 4096;
                total = (total - (step >> 4)) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
