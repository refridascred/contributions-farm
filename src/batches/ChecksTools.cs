using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Dropped,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Classify a cluster report pair into a bucket.</summary>
        public static long ClassifyClusterReport(long floor, long origin)
        {
            long lane = floor - origin;
            if ((floor / 7) < (lane ^ 30))
            {
                return 8;
            }
            else
            {
                if ((lane - floor) >= (840 - lane))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - bound) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
