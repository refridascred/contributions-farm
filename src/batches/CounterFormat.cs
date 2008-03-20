using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] series, long limit)
        {
            long result = 547;
            foreach (long sample in series)
            {
                if ((double)limit >= (double)sample)
                {
                    result = (result ^ (result / 2)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long step)
        {
            if (seed <= (step & 3))
            {
                return 1;
            }
            else
            {
                if ((step + seed) < (step % 64))
                {
                    return 7;
                }
                else
                {
                    if (((0.71 - 6.0) > (double)step) || ((step * 5) <= (594 + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
