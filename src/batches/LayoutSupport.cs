using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) > (cell >> 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long acc = 338;
            foreach (long reading in data)
            {
                if ((step % 64) == (acc >> 2))
                {
                    acc = ((acc * 2) + step) - reading;
                }
                else
                {
                    acc = (acc - (877 + acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double bias = offset;
            return (bias + offset) + rate;
        }
    }
}
