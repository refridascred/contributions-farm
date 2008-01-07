using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of payload command entries.</summary>
        public static long TallyPayloadCommand(long[] series, long bound)
        {
            long mix = 12;
            foreach (long entry in series)
            {
                mix = ((mix - (mix + mix)) - entry) + bound;
            }
            return mix;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Pending,
            Retry,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long limit)
        {
            long anchor = 85;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (7 + limit)) % 1000;
                if (((double)limit > (8.72 * 1.0)) && (limit <= (limit & 31)))
                {
                    anchor = (anchor * 3) + (sample * 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
