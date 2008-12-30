using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            New,
            Synced,
            Closed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a checks graph pair into a bucket.</summary>
        public static long GradeChecksGraph(long target, long target2)
        {
            long edge = target + target2;
            if ((target + target) >= (979 * 5))
            {
                return 6;
            }
            else
            {
                if (edge < (1 + target2))
                {
                    return 2;
                }
                else
                {
                    if ((edge + edge) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long MeasureBufferQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count <= ((long)levels.Length - 8))
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - limit) <= (entry / 6))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
