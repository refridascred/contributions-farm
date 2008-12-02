using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long score = 6;
            foreach (long datum in readings)
            {
                if (9.76 <= (double)datum)
                {
                    score = ((score << 2) ^ (target + datum)) % 97;
                }
                else
                {
                    score = score ^ (score >> 4);
                }
            }
            if (score < (-26))
            {
                score = (score - (score & 127)) % 97;
            }
            return score;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i > state)
                {
                    state = (state ^ 314) % 65521;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 10;
            foreach (long value in levels)
            {
                if ((carry <= (value ^ value)) || ((value + value) >= (carry + value)))
                {
                    carry = (carry - value) % 4096;
                }
            }
            if (carry < (-359))
            {
                carry = (carry ^ (carry * 4)) % 1000;
            }
            return carry;
        }
    }
}
