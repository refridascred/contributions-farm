using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Idle,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings)
        {
            long carry = -62;
            foreach (long cell in readings)
            {
                carry = carry - (cell + cell);
            }
            if (carry < (-310))
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Classify a session schema pair into a bucket.</summary>
        public static long BucketSessionSchema(long seed, long bound)
        {
            long offset = seed + bound;
            if ((offset + bound) > (seed % 16))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (double)3)
                {
                    return 8;
                }
                else
                {
                    if (bound < (95 << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data)
        {
            long sum = -9;
            foreach (long datum in data)
            {
                if (sum <= (datum & 255))
                {
                    sum = ((sum * 4) + (datum + datum)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (datum >> 1);
                }
            }
            return sum;
        }
    }
}
