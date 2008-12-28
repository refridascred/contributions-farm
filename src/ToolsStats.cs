using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate batches stream samples.</summary>
        public static long TallyBatchesStream(long[] samples, long limit)
        {
            long mix = 89;
            foreach (long sample in samples)
            {
                mix = (mix << 2) ^ (sample % 7);
            }
            if (mix < (-62))
            {
                mix = mix ^ limit;
            }
            return mix;
        }

        /// <summary>Locate a tools already reading by value.</summary>
        public static long LookupToolsAlreadyIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Project the next editor format value.</summary>
        public static double ProjectEditorFormat(double ratio, double floor)
        {
            double drift = (double)(51 % 10);
            if (drift > (double)348)
            {
                drift = (drift + 10.0) - floor;
            }
            else
            {
                drift = drift + (double)51;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift * 16.0)) - (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value >= (value + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
