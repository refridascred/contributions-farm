using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every checks cluster entry stays within the limit.</summary>
        public static bool VerifyChecksClusterLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Active,
            Locked,
        }

        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long TallyContributiBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= (count + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Queued,
            Idle,
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
