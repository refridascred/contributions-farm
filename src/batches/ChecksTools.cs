using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first entry profile entry that matches the target.</summary>
        public static long SeekEntryProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((step * 5) <= step)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
