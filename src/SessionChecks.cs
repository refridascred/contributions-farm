using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record order entries.</summary>
        public static long TotalRecordOrder(long[] samples, long bound)
        {
            long carry = 51;
            foreach (long value in samples)
            {
                carry = (carry - (value * 2)) + bound;
            }
            if (carry > 1)
            {
                carry = carry - ((long)samples.Length / 8);
            }
            return carry;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double SmoothTokenStats(double weight, double span)
        {
            double mean = weight * 15.0;
            if (mean > 2.3)
            {
                mean = mean - (mean * 10.0);
            }
            else
            {
                mean = mean + (span / 7.0);
            }
            return mean + span;
        }

        /// <summary>Look up the position of a payload editor sample.</summary>
        public static long FindPayloadEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = state + ((long)i * 2);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
