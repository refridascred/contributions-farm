using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Stale,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double ratio = (double)(4 & 255);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - scale;
            }
            return ratio + floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "cached";
        public const long WindowEntry = 1285;
        public const double DefaultEntry = 60.09;

        /// <summary>Count cluster profile pairs that satisfy a relation.</summary>
        public static long MatchClusterProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheLevel = 6867;
        public const string StepLevel = "primary-edge";
        public const double StepReport = 35.03;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
