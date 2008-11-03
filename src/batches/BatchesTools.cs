using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate cluster checks samples.</summary>
        public static long TallyClusterChecks(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                mix = mix ^ ((long)samples.Length + datum);
                if ((datum * 2) > (datum << 3))
                {
                    mix = (mix ^ (datum + datum)) % 101;
                }
            }
            if (mix > 407)
            {
                mix = (mix * 2) + (mix * 4);
            }
            return mix;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
