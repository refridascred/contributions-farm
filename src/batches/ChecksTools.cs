using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples, long origin)
        {
            long acc = 42;
            foreach (long sample in samples)
            {
                if ((acc / 9) >= (acc - acc))
                {
                    acc = (acc + (2 * 5)) % 255;
                }
                else
                {
                    acc = acc - (sample - acc);
                }
            }
            if (acc < 3)
            {
                acc = ((acc * 2) + (origin & 31)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count record stream pairs that satisfy a relation.</summary>
        public static long OverlapRecordStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
