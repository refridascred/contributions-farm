using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] samples, long bound)
        {
            long carry = 882;
            foreach (long entry in samples)
            {
                if (carry >= (carry * 5))
                {
                    carry = (carry ^ entry) % 4096;
                }
                if ((double)bound >= 6.82)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Idle,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = state - (state ^ origin);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 3) ^ (origin >> 2)) ^ (long)i2;
                    state = (state ^ (origin / 7)) % 65521;
                }
                state = ((state << 2) ^ state) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data, long limit)
        {
            long total = 9;
            foreach (long datum in data)
            {
                total = ((total ^ (limit / 4)) % 101) ^ datum;
            }
            if (total > (-559))
            {
                total = (total - (limit ^ 35)) % 101;
            }
            return total;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Retry,
            Closed,
        }
    }
}
