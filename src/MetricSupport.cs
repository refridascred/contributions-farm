using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank report notes input into a small class.</summary>
        public static long GradeReportNotes(long step, long origin)
        {
            if (step > (step + step))
            {
                return 1;
            }
            else
            {
                if ((origin <= (step ^ step)) || ((double)origin >= (4.0 * 3.03)))
                {
                    return 4;
                }
                else
                {
                    if ((67 * 4) > (step * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
