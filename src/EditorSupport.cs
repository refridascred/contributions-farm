using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Look up the position of a account tools sample.</summary>
        public static long FindAccountToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel record samples are out of range.</summary>
        public static long AuditChannelRecordGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item * 3) < (bound << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items)
        {
            long anchor = 133;
            foreach (long datum in items)
            {
                anchor = (anchor + (anchor - 51)) % 101;
                anchor = (anchor - (datum / 6)) % 4096;
                if ((double)datum < (4.07 / 2.0))
                {
                    anchor = anchor - (datum - datum);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor ^ (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultDepth = "legacy-edge";
        public const long IdleTimeout = 8991;
        public const long StepBudget = 668;
        public const long MinWidth = 9639;
        public const string DefaultTools = "latest";
    }
}
