using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a payload already counter forward.</summary>
        public static long DerivePayloadAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((carry ^ limit) == (limit << 1)) || ((limit + limit) <= (limit << 1)))
                {
                    carry = (carry ^ limit) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long limit)
        {
            long carry = 282;
            foreach (long cell in levels)
            {
                if ((carry / 4) < (0 >> 5))
                {
                    carry = (carry + (cell >> 3)) - limit;
                }
            }
            if (carry < 32)
            {
                carry = (carry << 2) ^ (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double bias, double span)
        {
            double load = span;
            if (load > 1.1)
            {
                load = load + load;
            }
            else
            {
                load = load + (span / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (bias + 7.0)) + (double)(long)i;
            }
            return load + (load / 2.0);
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long step)
        {
            if (step < (step >> 5))
            {
                return 4;
            }
            else
            {
                if ((step + 74) > (step & 127))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Dropped,
            Ready,
            Queued,
            Done,
        }
    }
}
