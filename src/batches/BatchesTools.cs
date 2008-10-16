using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long target, long target2)
        {
            if ((double)target < (9.0 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((target + target) < target)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (long)i) ^ value;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long origin)
        {
            long acc = 590;
            foreach (long reading in data)
            {
                acc = ((acc + (acc + (-9))) % 1000) - origin;
                if (acc <= (reading + reading))
                {
                    acc = (acc ^ (acc << 1)) % 65521;
                }
            }
            return acc;
        }
    }
}
