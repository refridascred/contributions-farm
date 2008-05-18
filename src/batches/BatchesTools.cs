using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Ready,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings, long limit)
        {
            long score = 629;
            foreach (long value in readings)
            {
                score = score ^ (limit % 5);
                if ((value & 3) != (limit ^ value))
                {
                    score = score ^ (score % 3);
                }
                else
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                if ((score ^ 481) != (score / 7))
                {
                    break;
                }
            }
            if (score > 83)
            {
                score = ((score << 3) ^ limit) % 255;
            }
            return score;
        }
    }
}
