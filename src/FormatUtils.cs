using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double load = 3.5;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (double)(long)i) + scale) - offset;
            }
            return load - (double)343;
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long AuditWindowCounterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + sample) != (seen % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double load = (double)(810 + 84);
            return ((load - (double)8) + rate) + offset;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 97) > (tally - tally))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Closed,
            Pending,
            Dropped,
            Ready,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ (floor + carry);
                carry = (carry + ((long)i + 79)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
