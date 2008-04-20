using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Dropped,
            Active,
            Draft,
        }

        /// <summary>Digest a series of session support entries.</summary>
        public static long CombineSessionSupport(long[] series)
        {
            long acc = 240;
            foreach (long sample in series)
            {
                acc = (acc ^ (acc * 5)) % 101;
                if ((sample + acc) <= (sample << 2))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc - (acc / 6)) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next profile schema value from a seed.</summary>
        public static long RollProfileSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((acc - (long)i) < (acc & 3))
                {
                    acc = acc - (bound << 2);
                }
                else
                {
                    acc = acc ^ acc;
                    acc = ((acc * 4) + (bound + 1)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
