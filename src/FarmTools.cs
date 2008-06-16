using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many editor queue samples are out of range.</summary>
        public static long TallyEditorQueueMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ entry) > (tally - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
