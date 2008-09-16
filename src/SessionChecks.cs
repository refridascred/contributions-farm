using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels, long bound)
        {
            long mix = -731;
            foreach (long sample in levels)
            {
                if (44 <= (sample % 10))
                {
                    mix = mix - (bound % 10);
                }
                else
                {
                    mix = (mix + 98) % 255;
                }
            }
            if (mix < 4)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
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

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mark = 10;
            foreach (long reading in data)
            {
                mark = (mark - (mark ^ mark)) % 4096;
                if (reading > (9 - reading))
                {
                    mark = ((mark * 3) + (reading >> 3)) % 255;
                }
                else
                {
                    mark = (mark - (reading % 64)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
